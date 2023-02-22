using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsolaProyecto
{
    class Program
    {
        public static void CarregarComandes()
        {
            Console.Write($"{Environment.NewLine}---------------------------------------------");
            Console.Write($"{Environment.NewLine}COMANDES: ");
            Console.Write($"{Environment.NewLine}A. AJUDA");
            Console.Write($"{Environment.NewLine}B. SORTIR");
            Console.Write($"{Environment.NewLine}C. FTP CONNEXIÓ");
            Console.Write($"{Environment.NewLine}D. NETEJAR CONSOLA");

            Console.Write($"{Environment.NewLine}---------------------------------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Title = "PROGRAMA CONNEXIÓ FTP";

            Console.Write($"{Environment.NewLine}---------------------------------------------");
            Console.Write($"{Environment.NewLine}---------------------------------------------");
            Console.WriteLine($"{Environment.NewLine}---------------------------------------------");
            Console.WriteLine("._,.\n" +
        "           \"..-..pf.\n" +
        "          -L   ..#'\n" +
        "        .+_L  .\"]#\n" +
        "        ,'j' .+.j`                 -'.__..,.,p.\n" +
        "       _~ #..<..0.                 .J-.``..._f.\n" +
        "      .7..#_.. _f.                .....-..,`4'\n" +
        "      ;` ,#j.  T'      ..         ..J....,'.j`\n" +
        "     .` ..\"^.,-0.,,,,yMMMMM,.    ,-.J...+`.j@\n" +
        "    .'.`...' .yMMMMM0M@^=`\"\"g.. .'..J..\".'.jH\n" +
        "    j' .'1`  q'^)@@#\"^\".`\"='BNg_...,]_)'...0-\n" +
        "   .T ...I. j\"    .'..+,_.'3#MMM0MggCBf....F.\n" +
        "   j/.+'.{..+       `^~'-^~~\"\"\"\"'\"\"\"?'\"``'1`\n" +
        "   .... .y.}                  `.._-:`_...jf\n" +
        "   g-.  .Lg'                 ..,..'-....,'.\n" +
        "  .'.   .Y^                  .....',].._f\n" +
        "  ......-f.                 .-,,.,.-:--&`\n" +
        "                            .`...'..`_J`\n" +
        "                            .~......'#'\n" +
        "                            '..,,.,_]`     Java the Hutt Group'\n" +
        "                            .L..`..``.     Programa de conexión FTP para descarga de EDIs");

            Console.Write($"{Environment.NewLine}---------------------------------------------");

            CarregarComandes();

            string option = "";

            while (option != "B")
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("OPCIÓ: ");
                    option = Console.ReadLine().ToUpper().Trim();

                    if (option == "D")
                    {
                        Console.Clear();
                    }
                    else if (option == "A")
                    {
                        Console.Clear();
                        CarregarComandes();
                    }
                    else if (option == "B")
                    {
                        Console.Write($"{Environment.NewLine}Press any key to exit...");
                        Console.ReadKey(true);
                    }
                    else if (option == "C")
                    {
                        //Connexión FTP
                        string filePath = "Recursos/credencialsFTP.xml";

                        XmlReaderSettings settings = new XmlReaderSettings();
                        settings.ConformanceLevel = ConformanceLevel.Document;
                        settings.IgnoreWhitespace = true;
                        settings.IgnoreComments = true;
                        settings.DtdProcessing = DtdProcessing.Ignore;

                        //reader principal per llegir ip i username;
                        XmlReader reader = XmlReader.Create(filePath, settings);
                        reader.ReadToFollowing("ip");
                        string ipFTP = reader.ReadElementContentAsString();
                        reader.ReadToFollowing("username");
                        string usernameFTP = reader.ReadElementContentAsString();
                        reader.Close();

                        //reader2 per llegir password ya que amb reader principal petaba en aquesta part
                        XmlReader reader2 = XmlReader.Create(filePath, settings);
                        reader2.ReadToFollowing("password");
                        string passwordFTP = reader2.ReadElementContentAsString();
                        reader2.ReadToFollowing("rutaCarpeta");
                        string textCarpeta = reader2.ReadElementContentAsString();
                        reader2.Close();

                        //Console.Write(ipFTP + "\n" + usernameFTP + "\n" + passwordFTP + "\n");

                        if (passwordFTP == "" || ipFTP == "" || usernameFTP == "")
                        {
                            throw new Exception("No es pot conectar al servidor FTP perque les dades no son correctes.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            try
                            {
                                //Imprimir estado de conexion al servidor FTP
                                FtpWebRequest ftpRequest1;
                                ftpRequest1 = (FtpWebRequest)WebRequest.Create("ftp://" + ipFTP + "/arxiuProva.txt");
                                ftpRequest1.Credentials = new NetworkCredential(usernameFTP, passwordFTP);
                                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest1.GetResponse();
                                Console.WriteLine(Convert.ToString(ftpResponse.WelcomeMessage));
                                ftpResponse.Close();

                                Console.Write("---------------------------------------------\n");
                                Console.Write("ARXIUS DISPONIBLES A DESCARREGAR DEL SERVIDOR:\n");

                                //Imprimir lista de archivos del servidor
                                FtpWebRequest ftpRequest2;
                                ftpRequest2 = (FtpWebRequest)WebRequest.Create("ftp://" + ipFTP + "/");
                                ftpRequest2.Credentials = new NetworkCredential(usernameFTP, passwordFTP);
                                ftpRequest2.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                                FtpWebResponse response1 = (FtpWebResponse)ftpRequest2.GetResponse();
                                Stream responseStream1 = response1.GetResponseStream();
                                StreamReader reader1 = new StreamReader(responseStream1);
                                Console.WriteLine(reader1.ReadToEnd());
                                reader1.Close();
                                response1.Close();

                                ////Demano el arxiu que l'usuari vol descarregar
                                //Console.Write("NOM FITXER A DESCARREGAR: ");
                                //string nomFitxer = Console.ReadLine().Trim();

                                //Descarreguem l'arxiu
                                FtpWebRequest ftpRequest3;
                                ftpRequest3 = (FtpWebRequest)WebRequest.Create("ftp://" + ipFTP + "/");
                                ftpRequest3.Credentials = new NetworkCredential(usernameFTP, passwordFTP);

                                ftpRequest3.Method = WebRequestMethods.Ftp.ListDirectory;
                                FtpWebResponse response = (FtpWebResponse)ftpRequest3.GetResponse();

                                StreamReader reader3 = new StreamReader(response.GetResponseStream());

                                string ftpServer = "ftp://" + ipFTP + "/";
                                string fileName = reader3.ReadLine();

                                if (!Directory.Exists(textCarpeta))
                                {
                                    Directory.CreateDirectory(textCarpeta);
                                }

                                while (!string.IsNullOrEmpty(fileName))
                                {
                                    string fileUrl = ftpServer + fileName;

                                    if (fileName.EndsWith(".edi"))
                                    {
                                        FtpWebRequest downloadRequest = (FtpWebRequest)WebRequest.Create(fileUrl);
                                        downloadRequest.Credentials = new NetworkCredential(usernameFTP, passwordFTP);
                                        downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile;

                                        using (FtpWebResponse downloadResponse = (FtpWebResponse)downloadRequest.GetResponse())
                                        using (Stream responseStream = downloadResponse.GetResponseStream())
                                        using (FileStream fileStream = new FileStream(textCarpeta + "/" + fileName, FileMode.Create))
                                        {
                                            responseStream.CopyTo(fileStream);
                                        }

                                        FtpWebRequest uploadRequest = (FtpWebRequest)WebRequest.Create("ftp://" + ipFTP + "/tractats/" + fileName);
                                        uploadRequest.Credentials = new NetworkCredential(usernameFTP, passwordFTP);
                                        uploadRequest.Method = WebRequestMethods.Ftp.UploadFile;

                                        using (Stream requestStream = uploadRequest.GetRequestStream())
                                        using (FileStream fileStream2 = new FileStream(textCarpeta + "/" + fileName, FileMode.Open))
                                        {
                                            fileStream2.CopyTo(requestStream);
                                        }

                                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fileUrl);
                                        request.Method = WebRequestMethods.Ftp.DeleteFile;
                                        request.Credentials = new NetworkCredential(usernameFTP, passwordFTP);

                                        using (FtpWebResponse response4 = (FtpWebResponse)request.GetResponse())
                                        {
                                            Console.WriteLine("Archivo recolocado en el servidor FTP correctamente");
                                        }
                                    }

                                    fileName = reader3.ReadLine();
                                }

                                Console.WriteLine($"Download Complete, status {response.StatusDescription}");
                                reader3.Close();
                                response.Close();

                                Console.WriteLine("---------------------------------------------");
                                Console.WriteLine("TOT FINALITZAT");
                                Console.WriteLine("---------------------------------------------");

                                Console.WriteLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }

                    }
                    else if (option.Length > 1 || option.Length == 0 || option != "A" || option != "B" || option != "C" || option != "D")
                    {
                        throw new Exception("NOMES ES POT ESCRIURE ELS CARACTERS, A/B/C/D, A OPCIÓ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
