using WebUI.Entities;

namespace WebUI.UseCases
{
    // Use Cases（用例）
    public interface IBMICalculator
    {
        float CalculateBMI(Ibmi bmi);
    }

    public class BMICalculator : IBMICalculator
    {
        public float CalculateBMI(Ibmi bmi)
        {
            // 計算BMI邏輯
            float heightInMeters = (float)bmi.Height / 100; // 將身高轉換為米
            float value = (float)bmi.Weight / (heightInMeters * heightInMeters); // BMI計算公式
            return value;
        }
    }
}
