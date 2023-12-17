using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PSocket
{
    public class Aptallık
    {

        public static string IpAdress = "127.0.0.1";
        public int Port = 50579;
        static byte[] adress = new byte[4];
        public IPAddress iPAdress = new IPAddress(Ata(IpAdress, adress));
        public bool listen = true;
        public bool send = true;
        public bool Bekle = true;
        public int PerSec = 1000;

        public int icinde = 15;

        Dictionary<int, Dictionary<int, Dictionary<int, string>>> sptr = new Dictionary<int, Dictionary<int, Dictionary<int, string>>>()
        {
           // {1,new Dictionary<int, Dictionary<int, string>>() //cift cri
           //{{1 , new Dictionary<int, string>{ { 5, @".15." } } },
           // {2 , new Dictionary<int, string>{ { 35, @".16."  } } },
           // {3 , new Dictionary<int, string>{ { 100, @".1." } } },
           // {4 , new Dictionary<int, string>{ { 15, @".2." } } },
           // {5 , new Dictionary<int, string>{ { 30, @".35." } } },
           // {6 , new Dictionary<int, string>{ { 30, @".34." } } },
           // }},
           // {2,new Dictionary<int, Dictionary<int, string>>()//tekcri
           //{//{1 , new Dictionary<int, string>{ { 5, @".15." } } },
           // {2 , new Dictionary<int, string>{ { 55, @".16."  } } },
           // {3 , new Dictionary<int, string>{ { 130, @".1." } } },
           // {4 , new Dictionary<int, string>{ { 20, @".2." } } },
           // {5 , new Dictionary<int, string>{ { 30, @".35." } } },
           // {6 , new Dictionary<int, string>{ { 30, @".34." } } },
           // }},
           // {3,new Dictionary<int, Dictionary<int, string>>()//stun
           //{{1 , new Dictionary<int, string>{ { 1, @".6." } } },
           // //{2 , new Dictionary<int, string>{ { 45, @".16."  } } },
           // {3 , new Dictionary<int, string>{ { 120, @".1." } } },
           // {4 , new Dictionary<int, string>{ { 20, @".2." } } },
           // {5 , new Dictionary<int, string>{ { 30, @".35." } } },
           // {6 , new Dictionary<int, string>{ { 30, @".34." } } },
           // }},
           // {4,new Dictionary<int, Dictionary<int, string>>()//freeze
           //{{1 , new Dictionary<int, string>{ { 1, @".7." } } },
           // //{2 , new Dictionary<int, string>{ { 45, @".16."  } } },
           // {3 , new Dictionary<int, string>{ { 120, @".1." } } },
           // {4 , new Dictionary<int, string>{ { 20, @".2." } } },
           // {5 , new Dictionary<int, string>{ { 30, @".35." } } },
           // {6 , new Dictionary<int, string>{ { 30, @".34." } } },
           // }},
           // {5,new Dictionary<int, Dictionary<int, string>>()//stunbadly
           //{{1 , new Dictionary<int, string>{ { 1, @".8." } } },
           // //{2 , new Dictionary<int, string>{ { 45, @".16."  } } },
           // {3 , new Dictionary<int, string>{ { 120, @".1." } } },
           // {4 , new Dictionary<int, string>{ { 20, @".2." } } },
           // {5 , new Dictionary<int, string>{ { 30, @".35." } } },
           // {6 , new Dictionary<int, string>{ { 30, @".34." } } },
           // }},
           // {6,new Dictionary<int, Dictionary<int, string>>()//sup1
           //{{1 , new Dictionary<int, string>{ { 18, @".26." } } },
           // {2 , new Dictionary<int, string>{ { 18, @".29." } } },
           // {3 , new Dictionary<int, string>{ { 12, @".30." } } },
           // }},
           // {7,new Dictionary<int, Dictionary<int, string>>()//sup2
           //{{1 , new Dictionary<int, string>{ { 18, @".26." } } },
           // {2 , new Dictionary<int, string>{ { 18, @".29." } } },
           // {3 , new Dictionary<int, string>{ { 14, @".27." } } },
           // {4 , new Dictionary<int, string>{ { 12, @".30." } } },
           // }},
           
            //ZİRH İCİN
            {1,new Dictionary<int, Dictionary<int, string>>()
           {{3 , new Dictionary<int, string>{ { 11, @".23." } } },
            {4 , new Dictionary<int, string>{ { 100, @".1."  } } },
            {5 , new Dictionary<int, string>{ { 60, @".22." } } },
            {6 , new Dictionary<int, string>{ { 19, @".37." } } },
            {7 , new Dictionary<int, string>{ { 34, @".33." } } },
            {8 , new Dictionary<int, string>{ { 10, @".34." } } },
            }},
            {2,new Dictionary<int, Dictionary<int, string>>()
           {{3 , new Dictionary<int, string>{ { 11, @".23." } } },
            {4 , new Dictionary<int, string>{ { 100, @".2."  } } },
            {5 , new Dictionary<int, string>{ { 60, @".22." } } },
            {6 , new Dictionary<int, string>{ { 19, @".37." } } },
            {7 , new Dictionary<int, string>{ { 34, @".33." } } },
            {8 , new Dictionary<int, string>{ { 10, @".35." } } },
            }},
            {3,new Dictionary<int, Dictionary<int, string>>()
           {{1 , new Dictionary<int, string>{ { 10, @".11." } } },
            {2 , new Dictionary<int, string>{ { 10, @".9." } } },
            {3 , new Dictionary<int, string>{ { 100, @".3."  } } },
            {4 , new Dictionary<int, string>{ { 60, @".22." } } },
            {5 , new Dictionary<int, string>{ { 19, @".37." } } },
            {6 , new Dictionary<int, string>{ { 34, @".33." } } },
            {7 , new Dictionary<int, string>{ { 10, @".36." } } },
            }},
            {4,new Dictionary<int, Dictionary<int, string>>()
           {{3 , new Dictionary<int, string>{ { 11, @".23." } } },
            {4 , new Dictionary<int, string>{ { 100, @".1."  } } },
            {5 , new Dictionary<int, string>{ { 19, @".4." } } },
            {6 , new Dictionary<int, string>{ { 19, @".37." } } },
            {7 , new Dictionary<int, string>{ { 34, @".33." } } },
            {8 , new Dictionary<int, string>{ { 10, @".34." } } },
            }},
            {5,new Dictionary<int, Dictionary<int, string>>()
           {{3 , new Dictionary<int, string>{ { 11, @".23." } } },
            {4 , new Dictionary<int, string>{ { 100, @".2."  } } },
            {5 , new Dictionary<int, string>{ { 19, @".4." } } },
            {6 , new Dictionary<int, string>{ { 19, @".37." } } },
            {7 , new Dictionary<int, string>{ { 34, @".33." } } },
            {8 , new Dictionary<int, string>{ { 10, @".35." } } },
            }},
            {6,new Dictionary<int, Dictionary<int, string>>()
           {{1 , new Dictionary<int, string>{ { 10, @".11." } } },
            {2 , new Dictionary<int, string>{ { 10, @".9." } } },
            {3 , new Dictionary<int, string>{ { 100, @".3."  } } },
            {4 , new Dictionary<int, string>{ { 19, @".4." } } },
            {5 , new Dictionary<int, string>{ { 19, @".37." } } },
            {6 , new Dictionary<int, string>{ { 34, @".33." } } },
            {7 , new Dictionary<int, string>{ { 10, @".36." } } },
            }},
           // {7,new Dictionary<int, Dictionary<int, string>>()
           //{{1 , new Dictionary<int, string>{ { 11, @".23." } } },
           // {2 , new Dictionary<int, string>{ { 100, @".1."  } } },
           // {3 , new Dictionary<int, string>{ { 39, @".17." } } },
           // {4 , new Dictionary<int, string>{ { 19, @".37." } } },
           // {5 , new Dictionary<int, string>{ { 34, @".33." } } },
           // {6 , new Dictionary<int, string>{ { 10, @".34." } } },
           // }},
           // {8,new Dictionary<int, Dictionary<int, string>>()
           //{{1 , new Dictionary<int, string>{ { 11, @".23." } } },
           // {2 , new Dictionary<int, string>{ { 100, @".2."  } } },
           // {3 , new Dictionary<int, string>{ { 39, @".17." } } },
           // {4 , new Dictionary<int, string>{ { 19, @".37." } } },
           // {5 , new Dictionary<int, string>{ { 34, @".33." } } },
           // {6 , new Dictionary<int, string>{ { 10, @".35." } } },
           // }},
           // {9,new Dictionary<int, Dictionary<int, string>>()
           //{{1 , new Dictionary<int, string>{ { 10, @".11." } } },
           // {2 , new Dictionary<int, string>{ { 10, @".9." } } },
           // {3 , new Dictionary<int, string>{ { 100, @".3."  } } },
           // {4 , new Dictionary<int, string>{ { 39, @".17." } } },
           // {5 , new Dictionary<int, string>{ { 19, @".37." } } },
           // {6 , new Dictionary<int, string>{ { 34, @".33." } } },
           // {7 , new Dictionary<int, string>{ { 10, @".36." } } },
           // }},
            {10,new Dictionary<int, Dictionary<int, string>>()
           {{3 , new Dictionary<int, string>{ { 11, @".23." } } },
            {4 , new Dictionary<int, string>{ { 60, @".22." } } },
            {5 , new Dictionary<int, string>{ { 34, @".33." } } },
            {6 , new Dictionary<int, string>{ { 19, @".37." } } },
            {7 , new Dictionary<int, string>{ { 10, @".34." } } },
            {8 , new Dictionary<int, string>{ { 10, @".35." } } },
            {9 , new Dictionary<int, string>{ { 4, @".36." } } },
            }},
           // {11,new Dictionary<int, Dictionary<int, string>>()
           //{{1 , new Dictionary<int, string>{ { 11, @".23." } } },
           // {2 , new Dictionary<int, string>{ { 40, @".17." } } },
           // {3 , new Dictionary<int, string>{ { 34, @".33." } } },
           // {4 , new Dictionary<int, string>{ { 19, @".37." } } },
           // {5 , new Dictionary<int, string>{ { 10, @".34." } } },
           // {6 , new Dictionary<int, string>{ { 10, @".35." } } },
           // {7 , new Dictionary<int, string>{ { 4, @".36." } } },
           // }},
            {12,new Dictionary<int, Dictionary<int, string>>()
           {{3 , new Dictionary<int, string>{ { 11, @".23." } } },
            {4 , new Dictionary<int, string>{ { 19, @".4." } } },
            {5 , new Dictionary<int, string>{ { 34, @".33." } } },
            {6 , new Dictionary<int, string>{ { 19, @".37." } } },
            {7 , new Dictionary<int, string>{ { 10, @".34." } } },
            {8 , new Dictionary<int, string>{ { 10, @".35." } } },
            {9 , new Dictionary<int, string>{ { 4, @".36." } } },
            }}
           
        };
        //Dictionary<int, Dictionary<int, string>> strpt = new Dictionary<int, Dictionary<int, string>>()
        //{
        //    {1 , new Dictionary<int, string>{ { 25, @".23." } } },
        //    {2 , new Dictionary<int, string>{ { 25, @".1."  } } },
        //    {3 , new Dictionary<int, string>{ { 25, @".22." } } },
        //    {4 , new Dictionary<int, string>{ { 25, @".37." } } },
        //    {5 , new Dictionary<int, string>{ { 25, @".33." } } },
        //    {6 , new Dictionary<int, string>{ { 25, @".34." } } },
        //};
        //Dictionary<int, Dictionary<List<string>,int>> Bakak = new Dictionary<int, Dictionary<List<string>, int>>()
        //};

        //List<List<string>> ListOfWhatWeWant = new List<List<string>>()
        //{
        //new List<string>() { @".23.", @".1.", @".22.", @".37.", @".33.", @".34."},
        //new List<string>() { @".23.", @".2.", @".22.", @".37.", @".33.", @".35."},
        //new List<string>() { @".3.", @".11.", @".22.", @".37.", @".33.", @".36."}
        //};

        //@".26.",@".29.",@".27.",@"4.30." sup
        // , @".23.", @".3.", @"4.4.", @".37.", @".33.", @".36." zrih  
        //, @".15.", @".16.", @".1.", @"4.2.", @"12.35.", @"12.34."
        // 4.4. s to overal
        // 4.22.  savunmada  hp
        // @".23." cri sansi
        //.37.  dodge
        //.33. defans
        //.36. mage dodge
        //.34. yakın dodge
        //.35. uzak dodge
        //.1.   yakın  savunma yükseltir
        //.2.   uzak 
        //.3.   magic
        // , @".11." buz

        void method()
        {
            foreach (var strpt in sptr)
            {
                foreach (var yuh in strpt.Value)
                {
                   
                }
            }
        }

        static byte[] Ata(string ipAdress, byte[] adress)
        {
            string[] a = ipAdress.Split('.');
            for (int i = 0; i < adress.Length; i++)
            {
                adress[i] = Convert.ToByte(a[i]);
            }
            return adress;
        }

        public void RecievePacketsFromServer()
        {
            try
            {
                using (Socket sender = new Socket(SocketType.Stream, ProtocolType.Tcp))
                {
                    IPEndPoint ipoint = new IPEndPoint(Convert.ToInt64(IpAdress), Port);
                    sender.Connect(ipoint);
                    MessageBox.Show("Connect Successfuly!");
                    while (true)
                    {
                        if (!listen)
                        {
                            sender.Shutdown(SocketShutdown.Both);
                            sender.Close();
                            break;
                        }
                        byte[] buffer = new byte[2048];
                        int recieved = sender.Receive(buffer);
                        string packages = Encoding.ASCII.GetString(buffer, 0, recieved);
                        string[] package = packages.Split(' ');
                        string first = package[0];
                        if (first == "1")
                            package[0] = "Send";
                        else
                            package[0] = "Recieve";
                        string packet = package.ToString();
                        // yazdırma işlemi burada olacak ya da , return ile 


                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(" Can not connect the server! : {0}", e.ToString());
            }

        }

        public async void SendPacketsToServer(string packet)
        {
            try
            {
                using (Socket sender = new Socket(SocketType.Stream, ProtocolType.Tcp))
                {
                    IPEndPoint ipoint = new IPEndPoint(Convert.ToInt64(IpAdress), Port);
                    sender.Connect(ipoint);
                    MessageBox.Show("Connect Successfuly!");
                    byte[] buffer = Encoding.ASCII.GetBytes("1 " + packet);
                    while (true)
                    {
                        if (!listen)
                        {
                            sender.Shutdown(SocketShutdown.Both);
                            sender.Close();
                            break;
                        }
                        int a = sender.Send(buffer);
                        Thread.Sleep(PerSec);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($" WARNING ! \n: {e}");
            }
        }

        public int SendAPer(string packet)
        {
            try
            {
                using (Socket sender = new Socket(SocketType.Stream, ProtocolType.Tcp))
                {
                    IPEndPoint ipoint = new IPEndPoint(iPAdress, Port);
                    sender.Connect(ipoint);

                    byte[] buffer = Encoding.ASCII.GetBytes("1 " + packet);
                    //int a = sender.Send(buffer);
                    int ge = 0;
                    int da = 0;
                    while (ge < 121)
                    {

                        byte[] bok = Encoding.ASCII.GetBytes("1 " + $"eqinfo 1 {da}");
                        Thread.Sleep(2000);
                        ge++;
                        da++;
                        if (!Bekle)
                        {
                            byte[] bok1 = Encoding.ASCII.GetBytes("1 " + $"mvi 0 {da - 1} 1 0");
                            sender.Send(bok1);
                            MessageBox.Show("Durdurdugun item 0. slotta");
                            BekleyiTrueYap();
                        }
                        if (!send)
                        {
                            send = true;
                            break;
                        }
                    }
                    return sender.Send(buffer);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        // kanka bu method yeni eklediğimiz butona basdıgımızda calısıcak
        private void BekleyiTrueYap()
        {
            while (!Bekle)
            {
                if (!send)
                    break;
                Thread.Sleep(5000);
            }
        }

        // Firstly This bot'll send packet up_gr for rare, and then send (eqinfo 1 {locationOfitem}).
        // After that system need to listen packet and we need to know packet of e_info and in this packet we need all elements
        // afterwards system will check recieve elements, and if has all our need elements system will be move this item any slot
        // and continue after item. 
        public void RightClick()
        {
            bool t = false;
            try
            {
                using (Socket sender = new Socket(SocketType.Stream, ProtocolType.Tcp))
                {
                    IPEndPoint ipoint = new IPEndPoint(iPAdress, Port);
                    sender.Connect(ipoint);

                    int da = 0;
                    int many = 6;
                    while (da < many)
                    {
                        byte[] upgr = Encoding.ASCII.GetBytes("1 " + $"up_gr 7 0 {da}");
                        byte[] eqinfo = Encoding.ASCII.GetBytes("1 " + $"eqinfo 1 {da}");
                        byte[] mvi = Encoding.ASCII.GetBytes("1 " + $"mvi 0 {da} 1 {many + da}");
                        byte[] gggg = Encoding.ASCII.GetBytes("1 " + $"guri 2");
                        //up_gr 7 0 {location}
                        while (true)
                        {
                            Thread.Sleep(500);
                            sender.Send(gggg);
                            // sistem çok yorulmasın diye düşündüm ama .d
                            Thread.Sleep(5000);
                            sender.Send(upgr);
                            //Thread.Sleep(1000);
                            //sender.Send(eqinfo);
                            Thread.Sleep(300);
                            if (RecievePacketsFromServer1(eqinfo, sptr))
                            {
                                t = true;
                                sender.Send(mvi);
                                da++;
                                Thread.Sleep(300);
                                break;
                            }

                        }
                        if (!send)
                        {
                            send = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        // gelen mesajı okuyacak bunu bir diziye atıyacak daha sonra bu diziyi gezicek içerisinde yukarıdaki listede
        // belirtilen seyler varmı yoksa 2 defa daha tekrarlıyacak
        public bool RecievePacketsFromServer1(byte[] eqinfo, Dictionary<int, Dictionary<int, Dictionary<int, string>>> sptr)
        {

            bool varmı = false, first = false;
            try
            {
                using (Socket sender = new Socket(SocketType.Stream, ProtocolType.Tcp))
                {
                    IPEndPoint ipoint = new IPEndPoint(iPAdress, Port);
                    sender.Connect(ipoint);
                    while (!first)
                    {
                        List<string[]> package = new List<string[]>();
                        List<bool> varmıs = new List<bool>();
                        sender.Send(eqinfo);
                        Thread.Sleep(300);
                        int g = 0;
                        int l = 20;
                        int index = -1;

                        if (!listen)
                            break;

                        package = ListenPackets(sender);

                        for (int i = 0; i < package.Count; i++)
                        {
                            if (package[i].Length <= 1)
                            {
                                continue;
                            }
                            if (package[i][1] == "e_info") // e_info geliyor fakat daha öncesinden paketler geldiği için e_infoyu bulamıyoryani 2. index dolu oldugu için bunun için burda e infoyu gezicez
                            {
                                index = i;
                                Console.WriteLine("Geldi ve Index degeri : " + index);
                                break;
                            }
                        }
                        if (index == -1)
                        {
                            continue;
                        }

                        bool ShouldItFinish = false;
                        foreach (var list in sptr)
                        {
                            for (int i = icinde; i < package[index].Length; i++)
                            {
                                foreach (var inList in list.Value)
                                {
                                    foreach (var twoInList in inList.Value)
                                    {
                                        var result = package[index][i].IndexOf(twoInList.Value);
                                        if (result != -1)
                                        {
                                            var parse = package[index][i].Split('.');
                                            if (Convert.ToInt32(parse[2]) >= twoInList.Key)
                                            {
                                                varmıs.Add(true);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            if (varmıs.Count != list.Value.Count) // istenilen midye gelmezse demek(istenilen deger result'un içinde varsa true deger eklenir yoksa eklenmez dolayısıyla bütün seyler gözden geçirildiğinde iki dizinin countları birbirine eşit olmazsa istenen durum yok demektir bu durumda recieve pakedinin false dönmesi gerekir)
                            {
                                Console.WriteLine("istenilen degerlerden ancak bu kadarı çıktı : " + varmıs.Count);
                                varmıs.Clear();
                                varmı = false;
                            }
                            else
                            {
                                
                                varmı = true;
                                ShouldItFinish = true;
                                break;
                            }
                        }
                        
                        first = true;
                    }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    if (varmı)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show($" Can not connect the server! : {e}");
            }
            return false;

        }

        private static List<string[]> ListenPackets(Socket sender)
        {
            //
            byte[] buffer = new byte[4096];
            int recieved = sender.Receive(buffer);
            string packages = Encoding.ASCII.GetString(buffer, 0, recieved);
            string[] package = packages.Split('\r');
            List<string[]> packagelist = new List<string[]>(package.Length);
            for (int i = 0; i < package.Length; i++)
            {
                string[] array = package[i].Split(' ');
                packagelist.Add(array);
            }
            return packagelist;
        }
    }

}

/*
 *                          int a = 0;
                            while (a < package.Length)
                            {
                                for (int b = 0; b < elements.Count; b++)
                                {
                                    if (package[a] == elements[b])
                                    {
                                        varmıs[g] = true;
                                        g++;
                                        break;
                                    }
                                }
                                if (!varmıs.Any(p => p == false))
                                {
                                    varmı = true;
                                    break;
                                }

                            }
 
 */

/*
                        for (int a = 0; a < package.Length; a++)
                        {
                            for (int b = 0; b < elements.Count; b++)
                            {
                                if (package[a] == elements[b])
                                {
                                    varmıs[g] = true;
                                    g++;
                                    break;
                                }
                            }
                            if (!varmıs.Any(p => p == false))
                            {
                                varmı = true;
                                break;
                            }
                        }
 */

/*
 //int a = 0;
                        //while (a < package.Count)
                        //{
                        //    for (int b = 0; b < elements.Count; b++)
                        //    {
                        //        //var result = string.Compare(elements[b], package[a]);
                        //        var result = package[a].IndexOf(elements[b]);
                        //        if (result != -1)
                        //        {
                        //            varmıs[g] = true;
                        //            g++;
                        //            break;
                        //        }
                        //    }
                        //    if (varmıs.Any(p => p == null || p == false))
                        //    {
                        //        a++;
                        //        continue;
                        //    }
                        //    else if (true)
                        //    {
                        //        varmı = true;
                        //        break;
                        //    }

                        //}
 */
