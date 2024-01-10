namespace JsonReceiptExtractor.Models
{
    public class JsonModel
    {
        public List<Line> lines { get; set; } = new List<Line>();

        //JSON dosyasından okuma yapılabilmesi için baş harfleri küçük tanımlanmıştır.
        public class Line
        {
            public string description { get; set; }
            public int[] coordinates { get; set; }
        }
    }


}
