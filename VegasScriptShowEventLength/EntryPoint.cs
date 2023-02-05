using ScriptPortal.Vegas;
using VegasScriptHelper;
using System;
using System.Windows.Forms;

namespace VegasScriptShowEventLength
{
    public class EntryPoint: IEntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            VegasHelper helper = VegasHelper.Instance(vegas);

            try
            {
                Timecode time = helper.GetLengthFromAllEventsInTrack();
                MessageBox.Show(time.ToString());
            }
            catch (VegasHelperTrackUnselectedException)
            {
                MessageBox.Show("ビデオトラックが選択されていません。");
            }
            catch (VegasHelperNoneEventsException)
            {
                MessageBox.Show("選択したビデオトラック中にイベントが存在していません。");
            }
        }
    }
}
