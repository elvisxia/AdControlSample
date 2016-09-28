using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace AdControlSample.ViewModels
{
    public class ArticleViewModel
    {
        public List<Article> Articles { get; set; }
        public ArticleViewModel()
        {
            Articles = new List<Article>
            {
                GenerateArticle(),
                GenerateArticle(),
                GenerateArticle(),
                GenerateArticle(),
                GenerateArticle(),
                GenerateArticle()
            };
        }

        private Article GenerateArticle()
        {
            Article article = new Article();
            article.UpdatedDate = DateTime.Now.ToString();
            article.HeadLine = "This is HeadLine";
            article.FontSize = 18.5;
            article.HeadlineFontSize = 22.5;
            article.Abstract = "This is Abstract";
            article.AbstractFontSize = 18.5;
            return article;
        }
    }



    public class Article
    {
        public String UpdatedDate { get; set; }
        public String HeadLine { get; set; }
        public Double FontSize { get; set; }
        public Double HeadlineFontSize { get; set; }
        public String Abstract { get; set; }

        public double AbstractFontSize { get; set; }

    }
}
