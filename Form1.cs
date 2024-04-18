using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _11._2_winforms
{
    public struct AEROFLOT
    {
        public string destin;
        public string flightNum;
        public string airType;

        public override string ToString()
        {
            return $"{destin} - {flightNum} - {airType}";
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxPlanes.DataSource = Airtypelist;
            object commandPlane = listBoxPlanes.SelectedItem;
            File.WriteAllText(filePath, string.Empty);
            GenerateFlights();
            Files(filePath, flightNumlist);
            FileRead(filePath);
        }
        string filePath = @"C:\novaya papka\11.22.txt";
        List<string> DestinList = new List<string> { "Moscow (MOW)", "St. Petersburg (LED)", "Tomsk (TOF)", "Kemerovo(KEJ)", "Saratov(RTW)", "Kazan (KZN)", "Kursk (KUR)", "Khabarovsk (KHV)", "Anapa (AAQ)", "Suzdal (Suz)" };
        List<string> Airtypelist = new List<string> { "Airbus, A320", "Boeing, 737", "Cessna, SkyHawk 172", "Dassault, Falcon 10", "Bombardier, Q series" };
        List<AEROFLOT> flightNumlist = new List<AEROFLOT>();
        private void GenerateFlights()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                string tempFlightNum = (rand.Next(100, 1000)).ToString("D3");
                string tempDest = DestinList[rand.Next(0, DestinList.Count)];
                string tempAirType = Airtypelist[rand.Next(0, Airtypelist.Count)];
                AEROFLOT plane = new AEROFLOT { destin = tempDest, flightNum = tempFlightNum, airType = tempAirType };
                flightNumlist.Add(plane);
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string commandPlane = (string)listBoxPlanes.SelectedItem;
            Search(commandPlane, flightNumlist);
        }
        private void Search(string commandPlane, List<AEROFLOT> Planelist)
        {
            IOrderedEnumerable<AEROFLOT>? List2 = Planelist.Where(a => a.airType == commandPlane).OrderBy(a => a.destin);
            List<AEROFLOT> listResult = new List<AEROFLOT>();
            if (List2.Any())
            {
                listResult = List2.ToList();
                listBox1.DataSource = listResult;
            }
            else
            {
                MessageBox.Show($"{commandPlane} не производит рейсов");
            }
        }
        private void Files(string filePath, List<AEROFLOT> planes)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (AEROFLOT plane in planes)
                {
                    writer.WriteLine($"Место прибытия: {plane.destin}, Номер самолета: {plane.flightNum}, Модель самолета: {plane.airType}");
                }
            }
        }
        private void FileRead(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                listBox2.Items.Add(line);
            }
        }

        private void labelPlaneModel_Click(object sender, EventArgs e)
        {

        }
    }
}