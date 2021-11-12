using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPAR
{
    public class Worker
    {
        public int Worker_Id { get; set; }
        public string Worker_Name { get; set; }

        /// <summary>
        /// This method used to insert into worker table
        /// </summary>
        /// <param name="em">Worker object</param>
        /// <returns>Successfully inserted or not</returns>
        public bool InsertIntoWorkerTable(Worker em)
        {
            // Insert into worker table.
            return true;
        }
    }

    public class IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        /// 
        public virtual void GenerateReport(Worker em)
        {
            // base.
        }

        /// <summary>
        /// Class to generate Crystal report
        /// </summary>
        /// 
        public class CrystalReportGeneration : IReportGeneration
        {
            public override void GenerateReport(Worker em)
            {
                base.GenerateReport(em);
                // Generate crystal report
            }
        }

        /// <summary>
        /// Class to generate PDF report
        /// </summary>
        /// 
        public class PDFReportGeneration : IReportGeneration
        {
            public override void GenerateReport(Worker em)
            {
                base.GenerateReport(em);
                // Generate PDF report
            }
        }
    }

    public abstract class Worker
    {
        public virtual string GetProductDetails(int workerId) => "Base Product";
        public virtual string GetWorkerDetails(int workerId)
        {
            return "Base Worker";
        }
    }

    public class CasualWorker : Worker
    {
        public override string GetProductDetails(int workerId)
        {
            return base.GetProductDetails(workerId);
        }
    }

    public class ContractWorker : Worker
    {
        public override string GetProductDetails(int workerId)
        {
            throw new NotImplementedException();
        }
    }

    public interface IAddOperation
    {
        bool AddWorkerDetails();
    }
    public interface IGetOperation
    {
        bool ShowWorkerDetails(int workerId);
    }

    public class Notification
    {
        private IMessenger _iMessenger;

        public Notification()
        {
        }
        public IMessenger MessageService
        {
            private get;
            set
            {
                _ iMessenger = (_)value;
            }
        }

        public void DoNotify()
        {
            SendMessage();
        }

        private void SendMessage()
        {
            throw new NotImplementedException();
        }
    }

    internal class _
    {
    }
}

