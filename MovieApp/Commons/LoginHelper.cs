﻿using Microsoft.IdentityModel.Tokens;
using MovieApp.Data.Entities;
using MovieApp.DTOs.Commons;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MovieApp.Commons
{
    public class LoginHelper
    {
        public static string BytesToHex(byte[] bytes)
        {
            StringBuilder res = new StringBuilder();
            for (int counter = 0; counter < bytes.Length; counter++)
            {
                res.Append(string.Format("{0:x2}", bytes[counter]));
            }
            return res.ToString();
        }

        public static string EncryptPassword(string password, string uid)
        {
            using var md5 = System.Security.Cryptography.MD5.Create();
            byte[] res = md5.ComputeHash(Encoding.UTF8.GetBytes(password + uid));
            return BytesToHex(res);
        }

        public static string GenerateToken(User user, JWT jwt)
        {
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Secret));

            var token = new JwtSecurityToken(
                issuer: jwt.ValidIssuer,
                audience: jwt.ValidAudience,
                expires: DateTime.Now.AddMonths(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
