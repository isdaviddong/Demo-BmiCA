namespace WebUI.Entities
{
    // Entities（實體）
    public interface Ibmi
    {
        int Height { get; set; }
        int Weight { get; set; }
        float Result { get; set; }
    }

    public class BMI : Ibmi
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public float Result { get; set; }
    }


}
