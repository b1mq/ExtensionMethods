namespace ExtMethids.Domain.Entities
{
    public static class Point3DExtension
    {
        public static double DistanceOfPoints(this Point3D PointA,Point3D PointB)
        {
            double X = PointB.x - PointA.x;
            double Y = PointB.y - PointA.y;
            double Z = PointB.z - PointA.z;
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }
    }
}
