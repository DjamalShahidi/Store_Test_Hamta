namespace Store.Persistence.Services
{
    public class JWTService
    {
        //private readonly IConfiguration _configuration;
        //private readonly SymmetricSecurityKey _jwtKey;

        //public JWTService(IConfiguration configuration)
        //{
        //    this._configuration = configuration;
        //    this._jwtKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));

        //}
        //public string CreateJWT(User user)
        //{
        //    var userClaims = new List<Claim>
        //    {
        //        new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
        //        new Claim(ClaimTypes.Email,user.Email),
        //        new Claim(ClaimTypes.GivenName,user.FirstName),
        //        new Claim(ClaimTypes.Surname,user.LastName)
        //    };

        //    var credentials = new SigningCredentials(_jwtKey, SecurityAlgorithms.HmacSha512Signature);
        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(userClaims),
        //        Expires = DateTime.UtcNow.AddDays(int.Parse(_configuration["JWT:ExpireInDays"])),
        //        SigningCredentials = credentials,
        //        Issuer = _configuration["JWT:Issuer"]
        //    };

        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var jwt = tokenHandler.CreateToken(tokenDescriptor);

        //    return tokenHandler.WriteToken(jwt);


        //}
    }
}
