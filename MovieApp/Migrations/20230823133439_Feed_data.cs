using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieApp.Migrations
{
    /// <inheritdoc />
    public partial class Feed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Dislike", "Image", "Like", "Title" },
                values: new object[,]
                {
                    { 5, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 5 title" },
                    { 6, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 6 title" },
                    { 7, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 7 title" },
                    { 8, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 8 title" },
                    { 9, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 9 title" },
                    { 10, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 10 title" },
                    { 11, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 11 title" },
                    { 12, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 12 title" },
                    { 13, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 13 title" },
                    { 14, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 14 title" },
                    { 15, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 15 title" },
                    { 16, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 16 title" },
                    { 17, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 17 title" },
                    { 18, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 18 title" },
                    { 19, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 19 title" },
                    { 20, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 20 title" },
                    { 21, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 21 title" },
                    { 22, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 22 title" },
                    { 23, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 23 title" },
                    { 24, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 24 title" },
                    { 25, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 25 title" },
                    { 26, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 26 title" },
                    { 27, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 27 title" },
                    { 28, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 28 title" },
                    { 29, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 29 title" },
                    { 30, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 30 title" },
                    { 31, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 31 title" },
                    { 32, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 32 title" },
                    { 33, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 33 title" },
                    { 34, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 34 title" },
                    { 35, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 35 title" },
                    { 36, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 36 title" },
                    { 37, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 37 title" },
                    { 38, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 38 title" },
                    { 39, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 39 title" },
                    { 40, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 40 title" },
                    { 41, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 41 title" },
                    { 42, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 42 title" },
                    { 43, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 43 title" },
                    { 44, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 44 title" },
                    { 45, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 45 title" },
                    { 46, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 46 title" },
                    { 47, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 47 title" },
                    { 48, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 48 title" },
                    { 49, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 49 title" },
                    { 50, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 50 title" },
                    { 51, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 51 title" },
                    { 52, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 52 title" },
                    { 53, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 53 title" },
                    { 54, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 54 title" },
                    { 55, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 55 title" },
                    { 56, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 56 title" },
                    { 57, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 57 title" },
                    { 58, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 58 title" },
                    { 59, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 59 title" },
                    { 60, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 60 title" },
                    { 61, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 61 title" },
                    { 62, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 62 title" },
                    { 63, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 63 title" },
                    { 64, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 64 title" },
                    { 65, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 65 title" },
                    { 66, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 66 title" },
                    { 67, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 67 title" },
                    { 68, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 68 title" },
                    { 69, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 69 title" },
                    { 70, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 70 title" },
                    { 71, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 71 title" },
                    { 72, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 72 title" },
                    { 73, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 73 title" },
                    { 74, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 74 title" },
                    { 75, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 75 title" },
                    { 76, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 76 title" },
                    { 77, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 77 title" },
                    { 78, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 78 title" },
                    { 79, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 79 title" },
                    { 80, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 80 title" },
                    { 81, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 81 title" },
                    { 82, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 82 title" },
                    { 83, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 83 title" },
                    { 84, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 84 title" },
                    { 85, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 85 title" },
                    { 86, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 86 title" },
                    { 87, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 87 title" },
                    { 88, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 88 title" },
                    { 89, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 89 title" },
                    { 90, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 90 title" },
                    { 91, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 91 title" },
                    { 92, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 92 title" },
                    { 93, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 93 title" },
                    { 94, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 94 title" },
                    { 95, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 95 title" },
                    { 96, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 96 title" },
                    { 97, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 97 title" },
                    { 98, 0, "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg", 0, "Movie 98 title" },
                    { 99, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s", 0, "Movie 99 title" },
                    { 100, 0, "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg", 0, "Movie 100 title" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Uid" },
                values: new object[] { "35b5d11496a69a14ba81244ab3b02fc2", new Guid("98baf0de-0bc1-488d-972d-abc28be9ecb1") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://st3.depositphotos.com/1064045/15061/i/450/depositphotos_150614902-stock-photo-unusual-cinema-concept-3d-illustration.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Uid" },
                values: new object[] { "c35c4af40b3b1c30faa5554955cdc445", new Guid("6377130d-8551-4274-86d8-52d23caa47d2") });
        }
    }
}
