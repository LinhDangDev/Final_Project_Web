﻿using System.Numerics;

namespace GettingStarted.Client.DAL
{
    public class ApplicationDataService
    {
        //ma_sinh_vien có kiểu dữ liệu là BigInt, identity(1,1)
        public long? ma_sinh_vien { get; set; }
        //nó là MSSV
        public string? ma_so_sinh_vien { get; set; }
        //sv thi ca nào
        public int? ma_ca_thi{ get; set; }
    }
}