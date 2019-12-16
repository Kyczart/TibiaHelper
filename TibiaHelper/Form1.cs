using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows;
using System.Threading;
using System.Diagnostics;
using System.Globalization;

namespace TibiaHelper
{
    public partial class Form1 : Form
    {
        //petla wyznaczajaca punkty w hp i mana <|----------|>
        int height;
        int width;
        int poczatek = 1771;
        int koniec = 1856;
        int HP_Y = 35;
        int Mana_Y = 48;


        public string DataLicencji = "9/30/2020";

        List<System.Drawing.Color> listaKolorowHP = new List<System.Drawing.Color>();
        List<System.Drawing.Color> listaKolorowMana = new List<System.Drawing.Color>();

        private bool boolCheckBoxHP;
        private bool boolCheckBoxMana;
        private bool boolCheckBoxUtama;
        private bool boolCheckBoxAutoClick;


        private string stringKeyHP;
        private string stringKeyHPStronger;
        private string stringKeyMana;
        private string stringKeyUtama;
        private string stringKeyAutoClick;


        private int stringpercentHP = 50;
        private int stringpercentHPStronger = 50;
        private int stringpercentMana = 50;
        public int AutoHotkeyTime = 10;


        public Form1()
        {
            try
            {


                InitializeComponent();
                GenerateHotkeys();
                GeneratePercents();
                SetCombobox();

                if (CheckScreen() == false)
                {
                    MessageBox.Show("Unsupported display resolution!\nPlease contakt with CandiaHelper@gmail.com\n\n Supported:\n1920x1080\n1600x900\n1440x900\n1366x768\n1680x1050\n1600x1024", "Contact CandiaHelper@gmail.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                


                if (SprawdzLicencje() == false)
                {
                    zamknijProgram();
                    this.Close();
                }
                else
                {

                    WczytajDaneLeczenia();
                    TaskBotStack();
                    //KontrolujLeczenieIMane();
                    //TaskBot();
                }




            }
            catch (Exception e)
            {
                this.Close();
            }


        }

        private void SetCombobox()
        {
            cmbHPUpper.SelectedIndex = 8;
            cmbHPUpperStronger.SelectedIndex = 4;
            cmbManaUpper.SelectedIndex = 6;
            txbAutoClick_TextChanged(null, null);

        }

        private bool CheckScreen()
        {
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;

            if (height == 1080 && width == 1920)
            {
                poczatek = 1771;
                koniec = 1856;
                HP_Y = 35;
                Mana_Y = 48;
                return true;
            }
            else if (height == 768 && width == 1366)
            {
                poczatek = 1217;
                koniec = 1301;
                HP_Y = 33;
                Mana_Y = 46;
                return true;
            }
            else if (height == 900 && width == 1440)
            {
                poczatek = 1291;
                koniec = 1375;
                HP_Y = 35;
                Mana_Y = 48;
                return true;
            }
            else if (height == 900 && width == 1600)
            {
                poczatek = 1451;
                koniec = 1536;
                HP_Y = 35;
                Mana_Y = 48;
                return true;
            }
            else if (height == 1050 && width == 1680)
            {
                poczatek = 1531;
                koniec = 1613;
                HP_Y = 35;
                Mana_Y = 48;
                return true;
            }
            else if (height == 1024 && width == 1600)
            {
                poczatek = 1451;
                koniec = 1536;
                HP_Y = 35;
                Mana_Y = 48;
                return true;
            }

            return false;

        }

        private bool SprawdzLicencje()
        {
            var myHttpWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("http://www.microsoft.com"); //aktualna data z neta
            var response = myHttpWebRequest.GetResponse();
            string todaysDates = response.Headers["date"];
            DateTime datetmp = DateTime.ParseExact(todaysDates,
                                       "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                                       CultureInfo.InvariantCulture.DateTimeFormat,
                                       DateTimeStyles.AssumeUniversal);
            DateTime DataDoPorownania = DateTime.Parse(DataLicencji, CultureInfo.InvariantCulture);
            if (datetmp < DataDoPorownania)
                return true;
            else return false;

        }


        private static void zamknijProgram()
        {
            MessageBox.Show("License expired!\nPlease contakt with CandiaHelper@gmail.com", "Contact CandiaHelper@gmail.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }





        //private static Bitmap CopyScreenhp()
        //{
        //    try
        //    {
        //        Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        //        Graphics graphics = Graphics.FromImage(bitmap);
        //        graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
        //        //bitmap.Save(@"c:\temp\screenshot.png");
        //        return bitmap;

        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }


        //    //MessageBox.Show("Time elapsed: {0} milliseconds " + sw.ElapsedMilliseconds.ToString());



        //}


        private void CopyScreen()
        {



            //Bitmap bitmap;
            //bitmap =  new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //    Graphics graphics = Graphics.FromImage(bitmap);
            //    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
            //bitmap.Save(@"c:\temp\screenshot.png");


            //Bitmap bitmap = null;
            //Bitmap 


            //tutaj wywala blad
            //bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            Rectangle bounds = Screen.GetBounds(Point.Empty);
            Bitmap bitmap = new Bitmap(1920, 1080);



            //Image bitmap = pictureBox1.Image ?? new Bitmap(bounds.Width, bounds.Height);

            //using (Graphics graphics = Graphics.FromImage(bitmap))
            //{
            //    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

            //    if (bitmap == null)
            //    {
            //        bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //        graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            //        screen = bitmap;
            //    }
            //    else
            //    {
            //        screen = bitmap;
            //    }

            //}







            //screen = bitmap;




        }






        public bool AreColorsSimilar(System.Drawing.Color c1, System.Drawing.Color c2, int tolerance)
        {
            return Math.Abs(c1.R - c2.R) < tolerance &&
                   Math.Abs(c1.G - c2.G) < tolerance &&
                   Math.Abs(c1.B - c2.B) < tolerance;
        }









        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }




        private void sprawdzhp()
        {

            //var sw = Stopwatch.StartNew();

            //Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
            //Bitmap screen = CopyScreenhp();
            //        //petla wyznaczajaca punkty w hp <|----------|>
            //        int poczatek = 1771;
            //        int koniec = 1856;
            //        int HP_Y = 35;
            //        int Mana_Y = 48;


            //        int tmpInt = (koniec - poczatek) / 10;


            //        listaKolorowHP.Clear();
            //        for (int i = 0; i < 10; i++)
            //        {
            //            //hp punkty
            //            listaKolorowHP.Add(screen.GetPixel(poczatek + (i * tmpInt), HP_Y));

            //            //mana punkty
            //            //   listaKolorowMana.Add(screen.GetPixel(poczatek + (i * tmpInt), Mana_Y));
            //        }
            //        listaKolorowHP.Add(screen.GetPixel(koniec, HP_Y));


            //        int licznikPunktowHP = 0;

            //if(listaKolorowHP.Count > 0)
            //{
            //    foreach (System.Drawing.Color color in listaKolorowHP)
            //    {
            //        if (AreColorsSimilar(listaKolorowHP[0], color, 10) == true)
            //        {
            //            licznikPunktowHP++;
            //        }
            //    }
            //}

            //sw.Stop();
            //// MessageBox.Show("Time elapsed: {0} milliseconds " + sw.ElapsedMilliseconds.ToString());
            //SendKeys.SendWait("{F1}");
            //// if (licznikPunktowHP < 9)  SendKeys.Send("{F1}");


        }

        private void checkboxHP_CheckStateChanged(object sender, EventArgs e)
        {

            //  MessageBox.Show("przed petla");



            //    sprawdzhp();

            WczytajDaneLeczenia();
            //KontrolujLeczenieIMane();






            //Task task = new Task(new Action(sprawdzhp));
            //task.Start();
            //task.Wait(200);
            //task.Dispose();



        }


        private async Task TaskBotStack()
        {
            using (var bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            using (var graphics = Graphics.FromImage(bitmap))
            {
                while (true)
                {
                    //cancel.ThrowIfCancellationRequested();
                    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
                    KontrolujLeczenieIMane(bitmap);
                    await Task.Delay(200);
                }
            }
        }




        private void TaskBot()
        {
            Task taskHeal = new Task(() =>
            {

                while (true)
                {
                    Thread.Sleep(200);
                    if (boolCheckBoxHP == true)
                    {
                        Bitmap bitmap;

                        try
                        {
                            bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); //here is an error
                            Graphics graphics = Graphics.FromImage(bitmap);
                            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message + "\n\nCause: " + "SpriteSet not yet loaded.");
                            bitmap = null;
                        }

                        KontrolujPoziomHP(bitmap);
                        if (bitmap != null) bitmap.Dispose();
                    }

                    if (boolCheckBoxMana == true)
                    {
                        Bitmap bitmap;

                        try
                        {
                            bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); //here is an error
                            Graphics graphics = Graphics.FromImage(bitmap);
                            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message + "\n\nCause: " + "SpriteSet not yet loaded.");
                            bitmap = null;
                        }
                        Thread.Sleep(50);
                        KontrolujPoziomMany(bitmap);
                        if (bitmap != null) bitmap.Dispose();
                    }
                }
            });
            taskHeal.Start();
        }


        private void WczytajDaneLeczenia()
        {
            //HP
            boolCheckBoxHP = checkboxHP.Checked;
            stringKeyHP = cmbHPKey.SelectedValue.ToString();
            stringKeyHPStronger = cmbHPKeyStronger.SelectedValue.ToString();
            stringpercentHP = Convert.ToInt32(cmbHPUpper.SelectedValue) / 10;
            stringpercentHPStronger = Convert.ToInt32(cmbHPUpperStronger.SelectedValue) / 10;


            //Mana
            boolCheckBoxMana = checkboxMana.Checked;
            stringKeyMana = cmbManaKey.SelectedValue.ToString();
            stringpercentMana = Convert.ToInt32(cmbManaUpper.SelectedValue) / 10;
        }



        private void KontrolujLeczenieIMane(Bitmap bitmap)
        {



            //Thread.CurrentThread.Priority = ThreadPriority.Highest;


            WczytajDaneLeczenia();

            if (boolCheckBoxHP == true)
            {
                KontrolujPoziomHP(bitmap);

            }



            if (boolCheckBoxMana == true)
            {
                KontrolujPoziomMany(bitmap);

            }



        }




        private void KontrolujPoziomHP(Bitmap bitmap)
        {


            //if (boolCheckBoxHP == true)
            //{
            //while (boolCheckBoxHP == true)
            //{


            // CopyScreen();












            if (bitmap != null)
            {
                int tmpInt = (koniec - poczatek) / 10;


                listaKolorowHP.Clear();
                for (int i = 0; i < 10; i++)
                {
                    //hp punkty
                    listaKolorowHP.Add(bitmap.GetPixel(poczatek + (i * tmpInt), HP_Y));

                    //mana punkty
                    //listaKolorowMana.Add(screen.GetPixel(poczatek + (i * tmpInt), Mana_Y));
                }
                listaKolorowHP.Add(bitmap.GetPixel(koniec, HP_Y));


                int licznikPunktowHP = 0;



                if (listaKolorowHP.Count > 0)
                {
                    foreach (System.Drawing.Color color in listaKolorowHP)
                    {
                        if (AreColorsSimilar(listaKolorowHP[0], color, 10) == true)
                        {
                            licznikPunktowHP++;
                        }
                    }
                }

                if (licznikPunktowHP < (stringpercentHPStronger + 2)) SendKeys.SendWait(stringKeyHPStronger);
                else if (licznikPunktowHP < (stringpercentHP + 2)) SendKeys.SendWait(stringKeyHP);


            }




        }


        private void KontrolujPoziomMany(Bitmap bitmap)
        {

            //while (boolCheckBoxMana == true)
            //{
            //  Bitmap screen = new Bitmap(obrazekTestowy);




            //Bitmap bitmap;
            //try
            //{

            //    bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //    Graphics graphics = Graphics.FromImage(bitmap);
            //    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message + "\n\nCause: " + "SpriteSet not yet loaded.");
            //    bitmap = null;
            //}



            if (bitmap != null)
            {

                int tmpInt = (koniec - poczatek) / 10;


                listaKolorowMana.Clear();
                for (int i = 0; i < 10; i++)
                {
                    //hp punkty
                    listaKolorowMana.Add(bitmap.GetPixel(poczatek + (i * tmpInt), Mana_Y));

                    //mana punkty
                    //listaKolorowMana.Add(screen.GetPixel(poczatek + (i * tmpInt), Mana_Y));
                }
                listaKolorowMana.Add(bitmap.GetPixel(koniec, Mana_Y));


                int licznikPunktowMany = 0;



                if (listaKolorowMana.Count > 0)
                {
                    foreach (System.Drawing.Color color in listaKolorowMana)
                    {
                        if (AreColorsSimilar(listaKolorowMana[0], color, 10) == true)
                        {
                            licznikPunktowMany++;
                        }
                    }
                }

                if (licznikPunktowMany < (stringpercentMana + 2)) SendKeys.SendWait(stringKeyMana);


            }




            //}
        }





        private class Hotkey
        {
            public string nazwaHotkeya { get; set; }
            public string wartoscHotkeya { get; set; }
        }

        List<Hotkey> lstHotkeys = new List<Hotkey>();
        private void GenerateHotkeys()
        {

            for (int i = 1; i < 13; i++)
            {
                Hotkey hotkey = new Hotkey();
                hotkey.nazwaHotkeya = "F" + i.ToString();
                hotkey.wartoscHotkeya = "{F" + i.ToString() + "}";
                lstHotkeys.Add(hotkey);
                // MessageBox.Show(hotkey.nazwaHotkeya + " " + hotkey.wartoscHotkeya);
            }
            List<Hotkey> lstHotkeysHP = new List<Hotkey>(lstHotkeys);

            cmbHPKey.DataSource = lstHotkeysHP;
            cmbHPKey.DisplayMember = "nazwaHotkeya";
            cmbHPKey.ValueMember = "wartoscHotkeya";

            List<Hotkey> lstHotkeysHPStronger = new List<Hotkey>(lstHotkeys);

            cmbHPKeyStronger.DataSource = lstHotkeysHPStronger;
            cmbHPKeyStronger.DisplayMember = "nazwaHotkeya";
            cmbHPKeyStronger.ValueMember = "wartoscHotkeya";

            List<Hotkey> lstHotkeysMana = new List<Hotkey>(lstHotkeys);
            cmbManaKey.DataSource = lstHotkeysMana;
            cmbManaKey.DisplayMember = "nazwaHotkeya";
            cmbManaKey.ValueMember = "wartoscHotkeya";

            List<Hotkey> lstHotkeysUtama = new List<Hotkey>(lstHotkeys);
            cmbUtamaKey.DataSource = lstHotkeysUtama;
            cmbUtamaKey.DisplayMember = "nazwaHotkeya";
            cmbUtamaKey.ValueMember = "wartoscHotkeya";


            List<Hotkey> lstHotkeysAutoClick = new List<Hotkey>(lstHotkeys);
            cmbAutoClickKey.DataSource = lstHotkeysUtama;
            cmbAutoClickKey.DisplayMember = "nazwaHotkeya";
            cmbAutoClickKey.ValueMember = "wartoscHotkeya";
        }


        private class Percents
        {
            public string nazwaHotkeya { get; set; }
            public string wartoscHotkeya { get; set; }
        }

        List<Percents> lstPercents = new List<Percents>();
        private void GeneratePercents()
        {

            for (int i = 0; i < 100; i += 10)
            {
                Percents percent = new Percents();
                percent.nazwaHotkeya = i.ToString() + "%";
                percent.wartoscHotkeya = i.ToString();
                lstPercents.Add(percent);
                // MessageBox.Show(hotkey.nazwaHotkeya + " " + hotkey.wartoscHotkeya);
            }
            List<Percents> lstPercentsHP = new List<Percents>(lstPercents);

            cmbHPUpper.DataSource = lstPercentsHP;
            cmbHPUpper.DisplayMember = "nazwaHotkeya";
            cmbHPUpper.ValueMember = "wartoscHotkeya";


            List<Percents> lstPercentsHPStronger = new List<Percents>(lstPercents);

            cmbHPUpperStronger.DataSource = lstPercentsHPStronger;
            cmbHPUpperStronger.DisplayMember = "nazwaHotkeya";
            cmbHPUpperStronger.ValueMember = "wartoscHotkeya";


            List<Percents> lstPercentsMana = new List<Percents>(lstPercents);
            cmbManaUpper.DataSource = lstPercentsMana;
            cmbManaUpper.DisplayMember = "nazwaHotkeya";
            cmbManaUpper.ValueMember = "wartoscHotkeya";



        }








        private void checkboxMana_CheckStateChanged(object sender, EventArgs e)
        {

            //if (boolCheckBoxMana == true)

            //{
            //    Task PilnowanieMany = new Task(() => {




            //         KontrolujPoziomMany();
            //    });


            //    PilnowanieMany.Start();
            //}


            WczytajDaneLeczenia();

            //KontrolujLeczenieIMane();





        }

        private void checkboxUtama_CheckStateChanged(object sender, EventArgs e)
        {
            boolCheckBoxUtama = checkboxUtama.Checked;
            stringKeyUtama = cmbUtamaKey.SelectedValue.ToString();
            if (boolCheckBoxUtama == true)

            {
                Task PilnowanieUtamy = new Task(() => {

                    KontrolujUtame();



                });


                PilnowanieUtamy.Start();
            }
        }

        private void KontrolujUtame()
        {
            Thread.Sleep(5000);
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            while (boolCheckBoxUtama == true)
            {
                SendKeys.SendWait(stringKeyUtama);

                Random rnd = new Random();
                int oczekiwanie = rnd.Next(52000, 62000);


                Thread.Sleep(oczekiwanie);
            }



        }

        private void checkboxAutoClick_CheckStateChanged(object sender, EventArgs e)
        {
            boolCheckBoxAutoClick = checkboxAutoClick.Checked;
            stringKeyAutoClick = cmbAutoClickKey.SelectedValue.ToString();
            if (boolCheckBoxAutoClick)

            {
                Task WciskaniePrzycisku = new Task(() => {

                    WciskajHotkey();



                });


                WciskaniePrzycisku.Start();
            }
        }



        private void WciskajHotkey()
        {
            Thread.Sleep(5000);
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            while (boolCheckBoxAutoClick == true)
            {
                SendKeys.SendWait(stringKeyAutoClick);
                Thread.Sleep(AutoHotkeyTime);
            }



        }

 
        private void txbAutoClick_TextChanged(object sender, EventArgs e)
        {
            AutoHotkeyTime = Convert.ToInt32(txbAutoClick.Text.ToString())*1000;
        }
    }
}
