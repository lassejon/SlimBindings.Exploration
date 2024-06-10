using MWPhotoBrowserBinding;

namespace MWPhotoBrowserWrapper.Library.iOS
{
    public class Exposer
    {
        public int ExposeItemCount()
        {
            // OriginalNative.Original.Mulityply();
            var itemCount = (int)MWPhotoBrowser.ItemCount();

            return itemCount;
        }
    }
}