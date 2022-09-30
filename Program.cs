namespace ClownConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            IScaryClown iScaryClownReference = (IScaryClown) fingersTheClown;
            iScaryClownReference.ScareLittleChildren();
        }
    }
}