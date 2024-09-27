using ArticleDashboard.Models;

public class ArticleService
{
    private List<Article> Articles = new List<Article>
    {
        new Article { Id = 1, Title = "First Article", Content = "This is the first article.", PublishedDate = DateTime.Now },
        new Article { Id = 2, Title = "Second Article", Content = "This is the second article.", PublishedDate = DateTime.Now }
    };

    public List<Article> GetArticles()
    {
        return Articles;
    }

    public Article GetArticleById(int id)
    {
        return Articles.FirstOrDefault(a => a.Id == id);
    }

    public void AddArticle(Article article)
    {
        Articles.Add(article);
    }

    public void UpdateArticle(Article article)
    {
        var existingArticle = Articles.FirstOrDefault(a => a.Id == article.Id);
        if (existingArticle != null)
        {
            existingArticle.Title = article.Title;
            existingArticle.Content = article.Content;
            existingArticle.PublishedDate = article.PublishedDate;
        }
    }

    public void DeleteArticle(int id)
    {
        var article = Articles.FirstOrDefault(a => a.Id == id);
        if (article != null)
        {
            Articles.Remove(article);
        }
    }
}
