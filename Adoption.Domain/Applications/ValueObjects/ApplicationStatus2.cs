//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ddd.ValueObjects
//{
//    internal enum AppState
//    {
//        NotOpened,
//        InProgress,
//        InFinalization,
//        RejectedByWorker,
//        WithdrawedByApplicant,
//        ClosedDueToAnotherApplicationSuccess
//    }
//    internal sealed class ApplicationStatus
//    {
//        internal AppState Status { get; private set; }

//        internal void SetStatus(AppState state)
//        {
//            if(state is AppState.InProgress && this.Status is AppState.Closed)
//            {
//                //throw new CanNotOpenClosedApplicationException()
//            }
//            this.Status = state;
//        }
//    }
//}
