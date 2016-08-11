
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Html;
using System.Linq.Expressions;
namespace System.Web.Mvc.Html
{
	public static class RadioListHelper
	{
		//this makes radio buttons with a clause
		public static MvcHtmlString ClauseRadioList<vals>(this HtmlHelper helper,string[] labelList,vals[] val,string name, string clause)
		{
			//gets all of the radio button values
			var radiobuttons = val;
			//makes all of the divs
			var rapup = new TagBuilder("div");
			var tagupsideform = new TagBuilder("div");
			tagupsideform.AddCssClass("upside-form");
			var tagclause = new TagBuilder("div");
			tagclause.AddCssClass("clauseform");
			var innerUpsideDiv = new TagBuilder("div");
			//makes all of the radio buttons
			for (int i = 0; i < labelList.Length; i++) {
				innerUpsideDiv.InnerHtml += InputExtensions.RadioButton(helper,name, radiobuttons[i]).ToHtmlString();
				innerUpsideDiv.InnerHtml += labelList[i];
				tagupsideform.InnerHtml += innerUpsideDiv.ToString();
				innerUpsideDiv.InnerHtml = "";
			}
			//adds in the clause ref
			var txt = InputExtensions.TextBox(helper, name, clause, new { @class = "bigger" });
			tagclause.InnerHtml = txt.ToString();
			rapup.InnerHtml= tagupsideform.ToString() + tagclause.ToString();

			return MvcHtmlString.Create(rapup.ToString());

		}
		//this makes radio buttons with a clause
		public static MvcHtmlString RadioList<vals>(this HtmlHelper helper, string[] labelList, vals[] val, string name, string clause)
		{
			//gets all of the radio button values
			var radiobuttons = val;
			//makes all of the divs
			var rapup = new TagBuilder("div");
			var tagupsideform = new TagBuilder("div");
			tagupsideform.AddCssClass("upside-form");

			var innerUpsideDiv = new TagBuilder("div");
			//makes all of the radio buttons
			for (int i = 0; i < labelList.Length; i++)
			{
				innerUpsideDiv.InnerHtml += InputExtensions.RadioButton(helper, name, radiobuttons[i]).ToHtmlString();
				innerUpsideDiv.InnerHtml += labelList[i];
				tagupsideform.InnerHtml += innerUpsideDiv.ToString();
				innerUpsideDiv.InnerHtml = "";
			}
			//adds in the clause ref

			rapup.InnerHtml = tagupsideform.ToString();

			return MvcHtmlString.Create(rapup.ToString());

		}
		//radio listfor with default value
		public static MvcHtmlString DefaultsRadioListFor<vals,TModel1,TResult1>
		(this HtmlHelper<TModel1> helper, Expression<Func<TModel1,TResult1>> otherVar, string[] labelList, vals[] val, vals defauls)
		{

			//gets all of the radio button values
			var radiobuttons = val;
			//makes all of the divs
			var rapup = new TagBuilder("div");
			var tagupsideform = new TagBuilder("div");
			tagupsideform.AddCssClass("upside-form");

			var innerUpsideDiv = new TagBuilder("div");
			//makes all of the radio buttons
			for (int i = 0; i < labelList.Length; i++)
			{
				if (radiobuttons[i].Equals(defauls)) {
					innerUpsideDiv.InnerHtml +=InputExtensions.RadioButtonFor(helper, otherVar, radiobuttons[i], new {@Checked=""}).ToHtmlString(); 
				}
				else { 
					innerUpsideDiv.InnerHtml += InputExtensions.RadioButtonFor(helper,otherVar,radiobuttons[i]).ToHtmlString();
				}
				innerUpsideDiv.InnerHtml += labelList[i];
				tagupsideform.InnerHtml += innerUpsideDiv.ToString();
				innerUpsideDiv.InnerHtml = "";
			}
			//adds in the clause ref



			rapup.InnerHtml = tagupsideform.ToString();

			return MvcHtmlString.Create(rapup.ToString());

		}

		public static MvcHtmlString DefaultClauseRadioListFor<TModel1, TResult1, TResult2,vals>
		(this HtmlHelper<TModel1> helper, Expression<Func<TModel1, TResult1>> otherVar,
		 Expression<Func<TModel1, TResult2>> Clause, string[] labelList, vals[] val, string clause, vals defauls)
		{
			var tagclause = new TagBuilder("div");
			tagclause.AddCssClass("clauseform");
			//gets all of the radio button values
			var radiobuttons = val;
			//makes all of the divs
			var rapup = new TagBuilder("div");
			var tagupsideform = new TagBuilder("div");
			tagupsideform.AddCssClass("upside-form");

			var innerUpsideDiv = new TagBuilder("div");
			//makes all of the radio buttons
			for (int i = 0; i < labelList.Length; i++)
			{
				if (radiobuttons[i].Equals(defauls)) { innerUpsideDiv.InnerHtml += InputExtensions.RadioButtonFor(helper, otherVar, radiobuttons[i], new { @Checked = "" }).ToHtmlString(); }
				else { innerUpsideDiv.InnerHtml += InputExtensions.RadioButtonFor(helper, otherVar, radiobuttons[i]).ToHtmlString(); }
				innerUpsideDiv.InnerHtml += labelList[i];
				tagupsideform.InnerHtml += innerUpsideDiv.ToString();
				innerUpsideDiv.InnerHtml = "";
			}
			//adds in the clause ref

			tagclause.InnerHtml = InputExtensions.TextBoxFor(helper, Clause, "", new { @class = "bigger", @Value = clause }).ToHtmlString();

			rapup.InnerHtml = tagupsideform.ToString() + tagclause.ToString();

			return MvcHtmlString.Create(rapup.ToString());

		}

		public static MvcHtmlString DefaultNoUpsideClauseRadioListFor<TModel1, TResult1, TResult2, vals>
		(this HtmlHelper<TModel1> helper, Expression<Func<TModel1, TResult1>> otherVar,
		 Expression<Func<TModel1, TResult2>> Clause, string[] labelList, vals[] val, string clause, vals defauls)
		{
			var tagclause = new TagBuilder("div");
			tagclause.AddCssClass("clauseform");
			//gets all of the radio button values
			var radiobuttons = val;
			//makes all of the divs
			var rapup = new TagBuilder("div");
			string d="";


			var innerUpsideDiv = new TagBuilder("div");
			//makes all of the radio buttons
			for (int i = 0; i < labelList.Length; i++)
			{
				if (radiobuttons[i].Equals(defauls)) { innerUpsideDiv.InnerHtml += InputExtensions.RadioButtonFor(helper, otherVar, radiobuttons[i], new { @Checked = "" }).ToHtmlString(); }
				else { innerUpsideDiv.InnerHtml += InputExtensions.RadioButtonFor(helper, otherVar, radiobuttons[i]).ToHtmlString(); }
				innerUpsideDiv.InnerHtml += labelList[i];
				d += innerUpsideDiv.ToString();
				innerUpsideDiv.InnerHtml = "";
			}
			//adds in the clause ref

			tagclause.InnerHtml = InputExtensions.TextBoxFor(helper, Clause, "", new { @class = "bigger", @Value = clause }).ToHtmlString();

			rapup.InnerHtml = d + tagclause.ToString();

			return MvcHtmlString.Create(rapup.ToString());

		}
	}
}

