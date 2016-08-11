using System;
using System.Collections.Generic;
using Loan_Portfolio.Models;
namespace Loan_Portfolio.Models
{
	public class AOContact
	{

		public string FullName { get; set; }
		public string Role { get; set; }
		public string Contact { get; set; }
	}
	public class CommitmentModel
	{

		public string Facility { get; set; }
		public string Currency { get; set; }
		public int Amount { get; set; }


	}

	public class EventPermit
	{
		public varClauseRef<string> TransferOtherLend { get; set; }
		public varClauseRef<string> DisclosureOtherLend { get; set; }
		public varClauseRef<string> TransferBankNFinancialInst { get; set; }
		public varClauseRef<string> DisclosureBankNFinancialInst { get; set; }

		//e
		public varClauseRef<string> TransferAnyEntitMakesLoans { get; set; }

		//f
		public varClauseRef<string> DisclosureAnyEntitMakesLoans { get; set; }
		public varClauseRef<string> AnyRequirPotentTransfereeRegulate { get; set; }

	}


	public class FacilityModel
	{
		public string Type { get; set; }
		public string Maturity { get; set; }
		public string Facility { get; set; }
		public string Currency { get; set; }
		public int Amount { get; set; }

	}
	public class SecurityModel
	{

		public string p1 { get; set; }
		public string p2 { get; set; }
		public string p3 { get; set; }
		public string p4 { get; set; }
		public string p5 { get; set; }
		public string Comment { get; set; }

	}
	public class varClauseRef<T>
	{
		public string ClauseRef { get; set; }
		public T OtherVar { get; set; }
	}

	public class varString<T>
	{
		public string STRING { get; set; }
		public varClauseRef<T> Bool { get; set; }
	}
	public class varNum<T>
	{
		public float Number { get; set; }
		public varClauseRef<T> Bool { get; set; }
	}
	public class FinancialCovenantsModel
	{
		public varClauseRef<bool> debtLeverage { get; set; }
		public varClauseRef<bool> interestCover { get; set; }
		public varClauseRef<bool> CashflowCover { get; set; }
		public varClauseRef<bool> tangibleNetWorth { get; set; }
	}


	public class ObligationCauseAgentModel
	{
		public varClauseRef<bool> DocByBorrowToCreditors { get; set; }
		public varClauseRef<bool> DetailLitArbAdminProcess { get; set; }
		public varClauseRef<bool> NotificAnyDefault { get; set; }
		public varClauseRef<bool> FurtherInfoRequestFinConBusOp { get; set; }
		public varClauseRef<bool> NotificChngeOwnerOfBorrow { get; set; }
		public varClauseRef<bool> NotificChngeConstDocObligor { get; set; }
		//ones with day input
		public varNum<bool> ConsAnnualFinancialStatement { get; set; }
		public varNum<bool> ConsSemiAnnualFinancialStatement { get; set; }
		public varNum<bool> ConsQuartAnnualFinancialStatement { get; set; }
		public varNum<bool> ConsMonthAnnualFinancialStatement { get; set; }
		public varNum<bool> UnConsAnnualFinancialStatement { get; set; }
		public varNum<bool> UnConsSemiAnnualFinancialStatement { get; set; }
		public varNum<bool> UnConsQuartAnnualFinancialStatement { get; set; }
		public varNum<bool> UnConsMonthAnnualFinancialStatement { get; set; }
	}


	public class FormIdentificationModel
	{

		public string Principle_Borrow { get; set; }
		public string AllenOveryCorM_Num { get; set; }
		public string Relevant_Facility { get; set; }
	}

	public class SettingsModel
	{
		public string Docname { get; set; }
		public string status { get; set; }
	}
	public class DocDetail
	{
		
		//settings
		public SettingsModel settings { get; set; }

		//security
		public SecurityModel Security { get; set; }


		//1.1
		public FormIdentificationModel FormIdentification { get; set; }
		//1.2
		public List<bool> Common_Venders { get; set; }
		public string AdditionalLenders { get; set; }
		public string final_report_dist_list { get; set; }
		//1.3
		public string PSponsor { get; set; }
		//1.4
		public string OrigDate { get; set; }
		//1.5
		public string Date { get; set; }
		//1.6
		public List<CommitmentModel> Commit { get; set; }
		//1.7
		public List<AOContact> Contacts { get; set; }
		//1.8

		public bool restricted { get; set; }


		//2.1
		public FacilityModel Facilities { get; set; }
		//2.2 
		public varClauseRef<string> PurposeClause { get; set; }
		//2.3
		public string consentlvl { get; set; }
		//2.4
		public string extension { get; set; }
		//2.5
		public varClauseRef<bool> CreditToInterestRate { get; set; }
		//2.6
		public varClauseRef<bool> DisposeMandatorPrepayment { get; set; }
		//2.7
		public varClauseRef<bool> ChangeMandatorPrepayment { get; set; }
		//2.8
		public varClauseRef<bool> CreditToTax_Gross_up { get; set; }
		//2.9
		public varClauseRef<bool> CreditToNegPledge { get; set; }
		//2.10
		public varClauseRef<bool> CreditToRestriction_IncurrringIndebtedness { get; set; }
		//2.11
		public FinancialCovenantsModel FinancialCovenants { get; set; }
		//2.12
		public varClauseRef<bool> MoreFinancialCovenants { get; set; }
		//2.13
		public ObligationCauseAgentModel ObligationCause { get; set; }
		//2.14
		public bool IsFailPayEvent { get; set; }
		//2.15
		public varClauseRef<bool> MaterialAdverseChangeEvent { get; set; }
		//2.16
		public varClauseRef<string> ProvCrossDefault_CrossAccel { get; set; }
		//2.17
		public varString<string> CrossDefOrAccelThresh { get; set; }
		//2.18
		public varClauseRef<bool> CAgrContClauseFavBank { get; set; }
		//2.19
		public string GovLawPrincCAgr { get; set; }
		//2.20
		public varClauseRef<bool> CAPArbitration { get; set; }


		//3.1
		public varClauseRef<bool> VoteOnPerameter { get; set; }
		//3.2
		public varClauseRef<string> LenderSplitCommitLoansVote { get; set; }
		//3.3
		public varClauseRef<string> SplitVoteDetail { get; set; }
		//3.4
		public varClauseRef<bool> HedgeBeforeEnf { get; set; }
		//3.5
		public varClauseRef<bool> HedgeAfterEnf { get; set; }


		//4.1
		public varClauseRef<string> ObligorNameJurJob { get; set; }
		//4.2
		public varClauseRef<bool> GuarantorsGuarantAllBorrow { get; set; }
		//4.3
		public varClauseRef<bool> DoesAgreeAllowAddBorrow { get; set; }
		//4.4
		public varClauseRef<string> ConsLvlAdditionBorrowersNewJur { get; set; }
		//4.5
		public varClauseRef<bool> DoesAgreeAllowAddGuarantors { get; set; }
		//4.6
		public varClauseRef<string> ConsLvlAdditionBorrowersExstJur { get; set; }
		//4.7
		public varClauseRef<string> ConsLvlAdditionGuarantorsExstJur { get; set; }
		//4.8
		public varClauseRef<string> ConsLvlAdditionGuarantorsNewJur { get; set; }

		//5.1
		public bool IsSecurity { get; set; }
		//5.2
		public string SecurityDescrip { get; set; }
		//5.3
		public string LawsGovSecurity { get; set; }
		//5.4
		public bool IsIntercreditorAgreement { get; set; }
		//5.5
		public bool SecurityBenefitHedge { get; set; }
		//5.6
		public bool IsOriginalDocProvidedToSecurityTrust { get; set; }


		//6.1,6.2
		public List<EventPermit> DefaultnoDefault { get; set; }
		//6.3
		public varClauseRef<bool> PotentTransfereeRequirEntNondisclosureAgree { get; set; }
		//6.4
		public varClauseRef<bool> WhenConsRequirForTransferGivenNoRefuse { get; set; }
		//6.5
		public varClauseRef<bool> ISConsentIssueBankRequirTrans { get; set; }
		//6.6
		public varClauseRef<string> ExceptionalCircRelevInf { get; set; }
		//6.7
		public varNum<string> minTransAmount { get; set; }
		//6.8
		public varClauseRef<int> LendersGrantSecurOverOwnRight { get; set; }

		//7.1 
		public varClauseRef<string> PermiteedInterPeriod { get; set; }
		//7.2
		public varClauseRef<string> ConsentRequirNonStandardInterPeriod { get; set; }
		//7.3
		public varClauseRef<string> NoticePerForSubUtilRequestSterling { get; set; }
		//7.4 
		public varClauseRef<string> NoticePerForSubUtilRequestNonSterling { get; set; }
		//7.5
		public varNum<string> NotePerForRepayLoan { get; set; }
		//7.6
		public varNum<string> NotePerForCancelCommit { get; set; }


		//8.1
		public varNum<string> InitPercMargin { get; set; }
		//8.2
		public varClauseRef<bool> AreCommitmentFees { get; set; }
		//8.3
		public varClauseRef<bool> AreUtilFees { get; set; }
		//8.4
		public varClauseRef<bool> VaryMargin { get; set; }


		//9.1
		public varClauseRef<bool> CreditAgreeContainConcDefaultLenders { get; set; }
		//9.2
		public varClauseRef<bool> CanObligorsOffAgainstOwedDefaultLenders { get; set; }


		//10.1
		public string AgentTypes { get; set; }


		//11.1
		public string OtherInfo { get; set; }
		public DocDetail()
		{
			DefaultnoDefault = new List<EventPermit>(2);
			Common_Venders = new List<bool>(30);
			Commit = new List<CommitmentModel>(1);
			Contacts = new List<AOContact>(1);
		}
	}
}

