using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangHung_ERP_System.Models
{
    public class HRWorld
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên ứng viên yêu cầu phải nhập.")]
        [MaxLength(50)]
        public string NameUngVien { get; set; }

        [Required]
        [MaxLength(50)]
        public string NgaySinh { get; set; }

        [MaxLength(50)]
        public string ThuocDoiTuong { get; set; }

        [MaxLength(50)]
        public string CanBoTuyenDung { get; set; }

        [MaxLength(50)]
        public string PhongTuyenDung { get; set; }

        [MaxLength(50)]
        public string CongTyTuyenDung { get; set; }

        [MaxLength(50)]
        public string TenJobs { get; set; }

        [MaxLength(50)]
        public string TuCtyCoJobs { get; set; }

        [MaxLength(50)]
        public string LoaiJobs { get; set; }

        [MaxLength(50)]
        public string PhuCap { get; set; }

        [MaxLength(50)]
        public string IncomeSalary { get; set; }

        [MaxLength(50)]
        public string EmployeeJob { get; set; }

        [MaxLength(50)]
        public string DoiTacCungCapJob { get; set; }

        [MaxLength(50)]
        public string YeuCauTiengNhatKhiThiTuyen { get; set; }

        [MaxLength(50)]
        public string YeuCauTiengNhatKhiBay { get; set; }

        [MaxLength(50)]
        public string MoreRequired { get; set; }

        [MaxLength(50)]
        public string Note { get; set; }

        [MaxLength(50)]
        public string YeuCauSoLuongTrungTuyenDuKien { get; set; }

        [MaxLength(50)]
        public string YeucauSoFormVaoThi { get; set; }

        [MaxLength(50)]
        public string NgayTienCu_ChotForm { get; set; }

        [MaxLength(50)]
        public string ThiTuyen { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> NgayThiTuyen { get; set; }

        [MaxLength(50)]
        public string HinhThucThiTuyen { get; set; }

        [MaxLength(50)]
        public string ThoiGianBayDuKien { get; set; }

        [MaxLength(50)]
        public string TrungTuyen { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> NgayTrungTuyen { get; set; }

        [MaxLength(50)]
        public string HopTacNguon_NeuCo { get; set; }

        [MaxLength(50)]
        public string MucChiaSeNguon { get; set; }

        [MaxLength(50)]
        public string TenDauNguon { get; set; }

        [MaxLength(50)]
        public string SDTDauNguon { get; set; }

        [MaxLength(50)]
        public string Email_Facebook { get; set; }

        [DefaultValue(false)]
        public Boolean DaXuatCanh { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> NgayXuatCanhThucTe { get; set; }

        [MaxLength(50)]
        public string TenXiNghiepUVLamVien { get; set; }

        [MaxLength(50)]
        public string TinhLamViec { get; set; }

        [MaxLength(50)]
        public string DiaChiLamViecChiTiet { get; set; }

        [MaxLength(50)]
        public string Phi { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> NgayThuPhi { get; set; }

        [MaxLength(50)]
        public string TiGiaChuyenDoiVND_USD { get; set; }

        [MaxLength(50)]
        public string TongPhiThuTuKH_USD { get; set; }

        [MaxLength(50)]
        public string PhiThuNhanTuKHTienVietLan1 { get; set; }

        [MaxLength(50)]
        public string TongPhiThuTuKH_USD2 { get; set; }

        [MaxLength(50)]
        public string PhiThuNhanTuKHTienVietLan2 { get; set; }

        [MaxLength(50)]
        public string TongPhiThuTuKH_USD3 { get; set; }

        [MaxLength(50)]
        public string PhiThuNhanTuKHTienVietLan3 { get; set; }

        [MaxLength(50)]
        public string TongPhiThuTuUV_USD1 { get; set; }

        [MaxLength(50)]
        public string PhiThuNhanTuUV_VND_Lan1 { get; set; }

        [MaxLength(50)]
        public string TongPhiThuTuUV_USD2 { get; set; }

        [MaxLength(50)]
        public string PhiThuNhanTuUV_VND_Lan2 { get; set; }

        [MaxLength(50)]
        public string TongPhiThuTuUV_USD3 { get; set; }

        [MaxLength(50)]
        public string PhiThuNhanTuUV_VND_Lan3 { get; set; }

        [MaxLength(50)]
        public string PhiTuyenDungNhanDuoc { get; set; }

        [MaxLength(50)]
        public string TongSoTienPhaiThu_USD { get; set; }

        [MaxLength(50)]
        public string TongSoTienDaThu { get; set; }

        public virtual City City { get; set; }

       // public virtual Company Company { get; set; }

        public virtual Department Department { get; set; }

        public virtual Jobmanager Jobmanager { get; set; }

    }
}