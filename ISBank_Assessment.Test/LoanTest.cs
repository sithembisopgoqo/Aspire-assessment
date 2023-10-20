using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISBank_Assessment.DL;
using ISBank_Assessment.BL;
using ISBank_Assessment.BE;

namespace ISBank_Assessment.Test
{
    [TestClass]
    public class LoanTest
    {

        [TestMethod]
        public void CalcLoanPaymentAmount()
        {
            var unitOfWork = new UnitOfWork(new DbContextFactory(null));

            LoanLogic loanLogic = new LoanLogic(unitOfWork);

            var loan = loanLogic.CalculateLoanPaymentAmount(5000,15,1);

        }
    }
}
