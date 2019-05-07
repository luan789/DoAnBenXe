using QLBX.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLBX.ViewModel
{
    public class KhachHangVM
    {
        private ObservableCollection<KHACHHANG> _KhachHangList;
        public ObservableCollection<KHACHHANG> KhachHangList
        {
            get { return _KhachHangList; }
            set { _KhachHangList= value; }
        }
        public KhachHangVM()
        {
            KhachHangList = new ObservableCollection<KHACHHANG>(DataProvider.Ins.DB.KHACHHANGs);
        }

    //public ICommand DeleteCommand { get; set; }

    //public ICommand Command { get; set; }


}
}
