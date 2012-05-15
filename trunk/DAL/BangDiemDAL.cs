﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAL
{
    public class BangDiemDAL : ConnectData
    {
        public DataTable LayDTDiem_HocKy_Lop(string MaLop, string MaHocKy)
        {
            string sql = string.Format("SELECT HS.TenHocSinh, PL.STT, BD.MaHocSinh, BD.MaMonHoc, "
                                        + " MH.TenMonHoc, "
                                        + " BD.MaHocKy, BD.DM_1, BD.DM_2, BD.D15_1, BD.D15_2, BD.D15_3, BD.D15_4, "
                                        + " BD.D1T_1, BD.D1T_1, BD.DThi "
                                        + " FROM BANGDIEM as BD, PHANLOP as PL, HOCSINH HS, MONHOC MH "
                                        + " WHERE BD.MaHocSinh=PL.MaHocSinh AND HS.MaHocSinh = PL.MaHocSinh "
                                        + " AND MH.MaMonHoc = BD.MaMonHoc "
                                        + " AND PL.MaLop = '{0}' AND "
                                        + " BD.MaHocKy = {1} ", MaLop, MaHocKy);
            return GetTable(sql);
        }
    }
}