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
    public class TaiXeVM:BaseViewModel
    {
        private  ObservableCollection<NHANVIENXE> _NhanVienXeList;
        public ObservableCollection<NHANVIENXE> NhanVienXeList
        {
            get { return _NhanVienXeList; }
            set { _NhanVienXeList = value; OnPropertyChanged(); }
        }
        
        public TaiXeVM()
        {
            NhanVienXeList = new ObservableCollection<NHANVIENXE>(DataProvider.Ins.DB.NHANVIENXEs);
        }
}
}
