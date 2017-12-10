using System;
using System.Collections.Generic;
namespace Clay.Models
{
    public class Lock:ILock
    {
        LockStatus status;

        public LockStatus GetLockStatus()
        {
            return status;
        }
        public Lock()
        {
            status = LockStatus.Closed;
        }
       
        public bool Open()
        {
            if(status == LockStatus.Opened)
            {
                throw new LockException("Already Opened");
            }
            status = LockStatus.Opened;
            return true;
        }
        public bool Close()
        {
            if(status == LockStatus.Closed)
            {
                throw new LockException("Already Closed");
            }
            status = LockStatus.Closed;
            return true;
        }
       
    }
}
