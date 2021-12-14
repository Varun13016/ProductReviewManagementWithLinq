using ProductReviewMangementWithLinq;
using System;
using System.Collections.Generic;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management problem Statement");

            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 1, UserID = 218, Rating = 0, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 213, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 216, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 217, Rating = 8, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 251, Rating = 9, Review = "Bad", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 215, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 7, UserID = 006, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 214, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 221, Rating = 6, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 206, Rating = 5, Review = "Good", isLike = true },
            };
            foreach (var list in listProductReview)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " " + "UserId: " + list.UserID + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " " + list.isLike + " ");
            }

            Console.WriteLine("-------------------------------------------------------------------");

            Management management = new Management();

            management.TopRecordsList(listProductReview);

            //management.SelectedRecords(listProductReview);
           // management.RetrieveCountOfRecords(listProductReview);
        }
    }
}