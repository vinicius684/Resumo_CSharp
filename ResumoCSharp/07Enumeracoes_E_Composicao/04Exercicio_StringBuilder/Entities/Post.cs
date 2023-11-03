using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7Enumeracoes_E_Composicao._04Exercicio_StringBuilder.Entities;

namespace CSharp._7Enumeracoes_E_Composicao._04Exercicio_StringBuilder.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //forma mais eficiente de fazer o ToString, da forma antiga teria de pegar Comments[0], Comments[1]...
        public override string ToString()//bem mais interessante para fazer alguma lógica
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment obj in Comments)
            {
                sb.AppendLine(obj.Text);
            }
            return sb.ToString();
        }
    }
}
