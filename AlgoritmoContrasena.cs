
private bool AlgoritmoContraseñaSegura(string password)
{
    mayuscula = false, minuscula = false, numero = false, carespecial = false; 
    for (int i = 0; i < password.Length; i++)
    {
        if (Char.IsUpper(password, i))
        {
            mayuscula = true;
        }
        else if (Char.IsLower(password, i))
        {
            minuscula = true;
        }
        else if (Char.IsDigit(password, i))
        {
            numero = true;
        }
        else
        {
            carespecial = true;
        }
    }
    if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
    {
        return true;
    }
    return false;
}
