using QLBX.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLBX.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        private List<KHACHHANG> _KhachHangList;

        public List<KHACHHANG> KhachHangList
        {
            get { return _KhachHangList; }
            set { _KhachHangList = value; OnPropertyChanged(); }
        }
        public bool Isloaded = false;
        public ICommand KhachHangCommand { get; set; }
        public MainViewModel()
        {
            if(!Isloaded)
            {
                Isloaded = true;
                LoginForm login = new LoginForm();
                login.ShowDialog();
            }
            KhachHangCommand = new RelayCommand<object>((p) => { return true; }, (p) => { KhachHangForm khf = new KhachHangForm(); ; khf.ShowDialog(); });
            LoadKhachHang();
        }
        public void LoadKhachHang()
        {
           // KhachHangList = DataProvider.Ins.DB.KHACHHANGs.ToList();
        }
    }
}
