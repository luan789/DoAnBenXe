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

        private List<NHANVIENXE> _NhanVienXeList;
        public List<NHANVIENXE> NhanVienXeList
        {
            get { return _NhanVienXeList; }
            set { _NhanVienXeList = value; OnPropertyChanged(); }
        }


        public bool Isloaded = false;
        public ICommand KhachHangCommand { get; set; }
        public ICommand TaiXeCommand { get; set; }
        public ICommand DatMuaVeCommand { get; set; }
        public ICommand NhanVienBanVeCommand { get; set; }
        public ICommand KhachGuiNhanHangCommand { get; set; }
        public ICommand ChuyenXeCommand { get; set; }
        public ICommand TuyenXeCommand { get; set; }
        public ICommand BaoCaoThongKeCommand { get; set; }
        public ICommand PhuXeCommand { get; set; }
        public ICommand GiaoNhanHangCommand { get; set; }
        public ICommand LoadedWindowCommand { get; set; }

        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Isloaded = true;
                LoginForm login = new LoginForm();
                if (p == null)
                    return;
                p.Hide();
                login.ShowDialog();
                if (login.DataContext == null)
                    return;
                var loginVM = login.DataContext as LoginVM;

                if (loginVM.IsLogin)
                {
                    p.Show();
                    LoadKhachHang();
                }
                else
                {
                    p.Close();
                }
            }
            );
            
            LoadNhanVienXe();
                
            
            KhachHangCommand = new RelayCommand<object>((p) => { return true; }, (p) => { KhachHangForm khf = new KhachHangForm(); ; khf.ShowDialog(); });
            TaiXeCommand = new RelayCommand<object>((p) => { return true; }, (p) => { TaiXeForm txf = new TaiXeForm(); ; txf.ShowDialog(); });
            DatMuaVeCommand = new RelayCommand<object>((p) => { return true; }, (p) => { DatMuaVeForm dmvf = new DatMuaVeForm(); ; dmvf.ShowDialog(); });
            NhanVienBanVeCommand = new RelayCommand<object>((p) => { return true; }, (p) => { NhanVienBanVeForm nvbvf = new NhanVienBanVeForm(); ; nvbvf.ShowDialog(); });
            KhachGuiNhanHangCommand = new RelayCommand<object>((p) => { return true; }, (p) => { KhachGuiNhanHangForm kgnhf = new KhachGuiNhanHangForm(); ; kgnhf.ShowDialog(); });
            ChuyenXeCommand = new RelayCommand<object>((p) => { return true; }, (p) => { ChuyenXeForm cxf = new ChuyenXeForm(); ; cxf.ShowDialog(); });
            TuyenXeCommand = new RelayCommand<object>((p) => { return true; }, (p) => { TuyenXeForm txf = new TuyenXeForm(); ; txf.ShowDialog(); });
            BaoCaoThongKeCommand = new RelayCommand<object>((p) => { return true; }, (p) => { BaoCaoThongKeForm bctkf = new BaoCaoThongKeForm(); ; bctkf.ShowDialog(); });
            PhuXeCommand = new RelayCommand<object>((p) => { return true; }, (p) => { PhuXeForm pxf = new PhuXeForm(); ; pxf.ShowDialog(); });
            GiaoNhanHangCommand = new RelayCommand<object>((p) => { return true; }, (p) => { GiaoNhanHangForm gnhf = new GiaoNhanHangForm(); ; gnhf.ShowDialog(); });


            
        }
        public void LoadKhachHang()
        {
            KhachHangList = DataProvider.Ins.DB.KHACHHANGs.ToList();
        }
        public void LoadNhanVienXe()
        {
            NhanVienXeList = DataProvider.Ins.DB.NHANVIENXEs.ToList();
        }
    }
}
