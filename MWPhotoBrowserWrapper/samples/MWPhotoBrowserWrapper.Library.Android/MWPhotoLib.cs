using MWPhotoBrowserWrapper.Android.Binding;

namespace MWPhotoBrowserWrapper.Library.Android
{
    public class MWPhotoLib
    {
        public int ItemCount()
        {
            int count = 0;

            var thread = new Thread(() =>
            {
                count = MWPhotoBrowserSdk.ItemCount;
            });

            thread.Start();
            Thread.Sleep(500);

            return count;
        }
    }
}