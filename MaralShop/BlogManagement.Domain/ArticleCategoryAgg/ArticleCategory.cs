﻿using _0_Framework.Domain;
using BlogManagement.Domain.ArticleAgg;

namespace BlogManagement.Domain.ArticleCategoryAgg
{
    public class ArticleCategory :EntityBase
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Description { get; private set; }
        public int ShowOrder { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string Slug { get; private set; }
        public string CanonicalAddress { get; private set; }
        public List<Article> Articles { get; private set; }

        public ArticleCategory()
        {
            Articles = new List<Article>();
        }

        public ArticleCategory(string name, string picture, string pictureAlt, string pictureTitle,
            string description, int showOrder, string keywords,
            string metaDescription, string slug, string canonicalAddress)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Description = description;
            ShowOrder = showOrder;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            CanonicalAddress = canonicalAddress;
        }

        public void Edit(string name, string picture, string pictureAlt, string pictureTitle,
            string description, int showOrder, string keywords,
            string metaDescription, string slug, string canonicalAddress)
        {
            Name = name;
            if (!string.IsNullOrWhiteSpace(picture))
            {
            Picture = picture;
            }
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Description = description;
            ShowOrder = showOrder;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            CanonicalAddress = canonicalAddress;
        }
    }
}
