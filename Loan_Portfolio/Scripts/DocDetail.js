function AOContact()
	{

		this.FullName="";
		this.Role="";
		this.Contact="";
	}
	function CommitmentModel()
	{

		this.Facility="";
		this.Currency="";
		this.Amount=0;


	}

	function EventPermit()
	{
		this.TransferOtherLend =new varClauseRef("");
		this.DisclosureOtherLend =new varClauseRef("");
		this.TransferBankNFinancialInst =new varClauseRef("");
		this.DisclosureBankNFinancialInst =new varClauseRef("");

		//e
		this.TransferAnyEntitMakesLoans =new varClauseRef("d");

		//f
		this.DisclosureAnyEntitMakesLoans =new varClauseRef("d");
		this.AnyRequirPotentTransfereeRegulate =new varClauseRef("d");

	}


	function FacilityModel()
	{
		this.Type="";
		this.Maturity="";
		this.Facility="";
		this.Currency="";
		this.Amount=0;

	}
	function SecurityModel()
	{

		this.p1="";
		this.p2="";
		this.p3="";
		this.p4="";
		this.p5="";
		this.Comment="";

	}
	function varClauseRef(i)
	{
		this.ClauseRef="";
		this.OtherVar=i;
	}

	function varString(i)
	{
		this.STRING="";
		this.Bool=new varClauseRef(i);
	}
	function varNum(i)
	{
		this.Number=0.0;
		this.Bool=new varClauseRef(i);
	}
	function FinancialCovenantsModel()
	{
		this.debtLeverage =new varClauseRef(false);
		this.interestCover =new varClauseRef(false);
		this.CashflowCover =new varClauseRef(false);
		this.tangibleNetWorth =new varClauseRef(false);
	}


	function ObligationCauseAgentModel()
	{
		this.DocByBorrowToCreditors =new varClauseRef(false);
		this.DetailLitArbAdminProcess =new varClauseRef(false);
		this.NotificAnyDefault =new varClauseRef(false);
		this.FurtherInfoRequestFinConBusOp =new varClauseRef(false);
		this.NotificChngeOwnerOfBorrow =new varClauseRef(false);
		this.NotificChngeConstDocObligor =new varClauseRef(false);
		//ones with day input
		this.ConsAnnualFinancialStatement =new varNum(false);
		this.ConsSemiAnnualFinancialStatement =new varNum(false);
		this.ConsQuartAnnualFinancialStatement =new varNum(false);
		this.ConsMonthAnnualFinancialStatement =new varNum(false);
		this.UnConsAnnualFinancialStatement =new varNum(false);
		this.UnConsSemiAnnualFinancialStatement =new varNum(false);
		this.UnConsQuartAnnualFinancialStatement =new varNum(false);
		this.UnConsMonthAnnualFinancialStatement =new varNum(false);
	}


	function FormIdentificationModel()
	{

		this.Principle_Borrow="";
		this.AllenOveryCorM_Num="";
		this.Relevant_Facility="";
	}

	function SettingsModel()
	{
		this.Docname="";
		this.status="";
	}
	function DocDetail()
	{
		
		//settings
		this.settings=new SettingsModel();

		//security
		this.Security=new SecurityModel();


		//1.1
		 this.FormIdentification = new FormIdentificationModel();
		//1.2
		this.Common_Venders = new Array(30);
		for(var i=0; i<this.Common_Venders.length;i++){
			this.Common_Venders[i]=false;
		}
		this.AdditionalLenders="";
		this.final_report_dist_list="";
		//1.3
		this.PSponsor="";
		//1.4
		this.OrigDate="";
		//1.5
		this.Date="";
		//1.6
		this.Commit=[];
		this.Commit.push(new CommitmentModel())


		//1.7
		this.Contacts=[];
		this.Contacts.push(new AOContact());
		//1.8

		this.restricted=false;


		//2.1
		this.Facilities=new FacilityModel();
		//2.2 
		this.PurposeClause =new varClauseRef("");
		//2.3
		this.consentlvl="";
		//2.4
		this.extension="";
		//2.5
		this.CreditToInterestRate =new varClauseRef(false);
		//2.6
		this.DisposeMandatorPrepayment =new varClauseRef(false);
		//2.7
		this.ChangeMandatorPrepayment =new varClauseRef(false);
		//2.8
		this.CreditToTax_Gross_up =new varClauseRef(false);
		//2.9
		this.CreditToNegPledge =new varClauseRef(false);
		//2.10
		this.CreditToRestriction_IncurrringIndebtedness =new varClauseRef(false);
		//2.11
		this.FinancialCovenants=new FinancialCovenantsModel();
		//2.12
		this.MoreFinancialCovenants =new varClauseRef(false);
		//2.13
		this.ObligationCause=new ObligationCauseAgentModel();
		//2.14
		this.IsFailPayEvent=false;
		//2.15
		this.MaterialAdverseChangeEvent =new varClauseRef(false);
		//2.16
		this.ProvCrossDefault_CrossAccel =new varClauseRef("");
		//2.17
		this.CrossDefOrAccelThresh = new varString("");
		//2.18
		this.CAgrContClauseFavBank =new varClauseRef(false);
		//2.19
		this.GovLawPrincCAgr="";
		//2.20
		this.CAPArbitration =new varClauseRef(false);


		//3.1
		this.VoteOnPerameter =new varClauseRef(false);
		//3.2
		this.LenderSplitCommitLoansVote =new varClauseRef("");
		//3.3
		this.SplitVoteDetail =new varClauseRef("");
		//3.4
		this.HedgeBeforeEnf =new varClauseRef(false);
		//3.5
		this.HedgeAfterEnf =new varClauseRef(false);


		//4.1
		this.ObligorNameJurJob =new varClauseRef("");
		//4.2
		this.GuarantorsGuarantAllBorrow =new varClauseRef(false);
		//4.3
		this.DoesAgreeAllowAddBorrow =new varClauseRef(false);
		//4.4
		this.ConsLvlAdditionBorrowersNewJur =new varClauseRef("");
		//4.5
		this.DoesAgreeAllowAddGuarantors =new varClauseRef(false);
		//4.6
		this.ConsLvlAdditionBorrowersExstJur =new varClauseRef("");
		//4.7
		this.ConsLvlAdditionGuarantorsExstJur =new varClauseRef("");
		//4.8
		this.ConsLvlAdditionGuarantorsNewJur =new varClauseRef("");



		//5.1
		this.IsSecurity=false;
		//5.2
		this.SecurityDescrip="";
		//5.3
		this.LawsGovSecurity="";
		//5.4
		this.IsIntercreditorAgreement=false;
		//5.5
		this.SecurityBenefitHedge=false;
		//5.6
		this.IsOriginalDocProvidedToSecurityTrust=false;


		//6.1,6.2
		this.DefaultnoDefault=[];
		this.DefaultnoDefault.push(new EventPermit());
		this.DefaultnoDefault.push(new EventPermit());
		//6.3
		this.PotentTransfereeRequirEntNondisclosureAgree =new varClauseRef(false);
		//6.4
		this.WhenConsRequirForTransferGivenNoRefuse =new varClauseRef(false);
		//6.5
		this.ISConsentIssueBankRequirTrans =new varClauseRef(false);
		//6.6
		this.ExceptionalCircRelevInf =new varClauseRef("");
		//6.7
		this.minTransAmount =new varNum("");
		//6.8
		this.LendersGrantSecurOverOwnRight =new varClauseRef(0);

		//7.1 
		this.PermiteedInterPeriod =new varClauseRef("");
		//7.2
		this.ConsentRequirNonStandardInterPeriod =new varClauseRef("");
		//7.3
		this.NoticePerForSubUtilRequestSterling =new varClauseRef("");
		//7.4 
		this.NoticePerForSubUtilRequestNonSterling =new varClauseRef("");
		//7.5
		this.NotePerForRepayLoan =new varNum("");
		//7.6
		this.NotePerForCancelCommit =new varNum("");


		//8.1
		this.InitPercMargin =new varNum("");
		//8.2
		this.AreCommitmentFees =new varClauseRef(false);
		//8.3
		this.AreUtilFees =new varClauseRef(false);
		//8.4
		this.VaryMargin =new varClauseRef(false);


		//9.1
		this.CreditAgreeContainConcDefaultLenders =new varClauseRef(false);
		//9.2
		this.CanObligorsOffAgainstOwedDefaultLenders =new varClauseRef(false);


		//10.1
		this.AgentTypes="";

		//11.1
		this.OtherInfo="";
	}
