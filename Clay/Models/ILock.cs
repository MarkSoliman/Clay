using System;
namespace Clay.Models
{
    public interface ILock
    {
        LockStatus GetLockStatus();
        bool Open();
        bool Close();

    }
}
