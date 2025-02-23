﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

// ReSharper disable All

namespace DHHTools
{
    public class DhhViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Tạo phương thức OnPropertyChanged(“propertyName”) để xử lý việc thay đổi value của Property.
        ///  propertyName là tên của Property bị Changed value.
        /// CallerMemberName: cho phép lấy “propertyName” mặc định là một phương thức hoặc thuộc tính gọi 
        /// phương thức OnPropertyChanged
        /// </summary>
        /// <param name="propertyName">Tên của Property bị Changed value</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}