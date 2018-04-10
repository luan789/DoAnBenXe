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
        private List<KHACHHANG> _KhachHangList;

        public List<KHACHHANG> KhachHangList
        {
            get { return _KhachHangList; }
            set { _KhachHangList= value; }
        }

        QLBXEntities DB = new QLBXEntities();


        public KhachHangVM()
        {
            var khachhang = DB.KHACHHANGs.ToList();
            KhachHangList = khachhang;

        //DeleteCommand = new RelayCommand<object>((p) => p != null, (p) => {
        //    Listf.Remove(p as SINHVIEN);
        //});
    }

    //public ICommand DeleteCommand { get; set; }

    //public ICommand Command { get; set; }


}
}
