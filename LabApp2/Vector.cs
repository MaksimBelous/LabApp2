using System;

namespace LabApp2
{
    public class Vector : IComparable<Vector>
    {
        private string LineColor { get; }
        private int Length { get; set; }
        private double Angle { get; set; }

        public Vector(string lineColor, int length, double angle)
        {
            LineColor = lineColor;
            Length = length;
            Angle = angle;
        }

        public void IncreaseVector(int number)
        {
            Length *= number;
            double newAngle = Angle * number;
            Angle = newAngle > 360 ? 360 - newAngle : newAngle;
        }

        public void DecreaseVector(int number)
        {
            Length /= number;
            Angle /= number;
        }

        public override string ToString()
        {
            return $"LineColor: {LineColor} Length: {Length} Angle: {Angle}";
        }

        public int CompareTo(Vector other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var lengthComparison = Length.CompareTo(other.Length);
            if (lengthComparison != 0) return lengthComparison;
            return Angle.CompareTo(other.Angle);
        }
    }
}