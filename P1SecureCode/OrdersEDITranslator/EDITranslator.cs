using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrdersEDITranslator
{
    public class EDITRanslator
    {
        private string _file;

        private SecureCoreG4Entities _context;

        public string FileDirectory
        {
            get { return _file; }
            set { _file = value; }
        }

        public EDITRanslator(string file)
        {
            FileDirectory = file;
        }

        public SecureCoreG4Entities translateEDI()
        {
            string[] processedEdi;
            Orders order = new Orders();

            List<OrdersDetail> ordersDetails = new List<OrdersDetail>();
            OrdersDetail currentDetails = new OrdersDetail();
            OrderInfo orderinfo = new OrderInfo();

            _context = new SecureCoreG4Entities();
            foreach (string line in File.ReadLines(_file))
            {
                processedEdi = line.Split('|');

                if (processedEdi[0] == "ORD")
                {
                    order.codeOrder = processedEdi[1];

                    Priority priority = Extension<Priority>.getOrderData("CodePriority", processedEdi[2], _context.Priority.ToList());

                    order.Priority = priority;
                }
                else if (processedEdi[0] == "DTM")
                {
                    DateTime date = new DateTime(Int32.Parse(processedEdi[1].Substring(0, 4)),
                        Int32.Parse(processedEdi[1].Substring(4, 2)),
                        Int32.Parse(processedEdi[1].Substring(6, 2)));

                    order.dateOrder = date;
                }
                else if (processedEdi[0] == "NADMS")
                {
                    orderinfo.OperationalAreas =
                        Extension<OperationalAreas>.getOrderData("CodeOperationalArea", processedEdi[1], _context.OperationalAreas.ToList());

                    orderinfo.Agencies =
                        Extension<Agencies>.getOrderData("CodeAgency", processedEdi[2], _context.Agencies.ToList());

                    order.OrderInfo.Add(orderinfo);

                    orderinfo.Orders = order;
                }
                else if (processedEdi[0] == "NADMR")
                {
                    order.Factories =
                        Extension<Factories>.getOrderData("codeFactory", processedEdi[1], _context.Factories.ToList());
                }
                else if (processedEdi[0] == "LIN")
                {
                    currentDetails = new OrdersDetail();

                    currentDetails.Planets =
                        Extension<Planets>.getOrderData("CodePlanet", processedEdi[1], _context.Planets.ToList());
                    currentDetails.References =
                        Extension<References>.getOrderData("codeReference", processedEdi[2], _context.References.ToList());
                }
                else if (processedEdi[0] == "QTYLIN")
                {
                    if (processedEdi[1] == "21")
                    {
                        currentDetails.Quantity = short.Parse(processedEdi[2]);
                    }
                    else if (processedEdi[1] == "61")
                    {
                        currentDetails.Quantity = (short)-short.Parse(processedEdi[2]);
                    }
                }
                else if (processedEdi[0] == "DTMLIN")
                {
                    DateTime datedelivery = new DateTime(Int32.Parse(processedEdi[1].Substring(0, 4)),
                        Int32.Parse(processedEdi[1].Substring(4, 2)),
                        Int32.Parse(processedEdi[1].Substring(6, 2)));

                    currentDetails.DeliveryDate = datedelivery;

                    //Aqui sobreescribe y por eso solo sube 1
                    //( la solución era inicializarlo cada vez, al no inicializarlo el Entity cree que es de la misma Id)
                    order.OrdersDetail.Add(currentDetails);
                    currentDetails.Orders = order;

                    ordersDetails.Add(currentDetails);

                }

            }
            foreach (OrdersDetail detail in ordersDetails)
            {
                _context.OrdersDetail.Add(detail);

            }
            _context.OrderInfo.Add(orderinfo);
            _context.Orders.Add(order);

            _context.SaveChanges();

            return _context;
        }

    }

}
