# my-links-tutorial
Projeto baseado nos tutoriais do canal Code FC

Atualização em 29/07

O projeto inicialmente não estava compilando devido a ausência dos pacotes Microsoft.AspNetCore.OpenApi e Swashbuckle.AspNetCore. Desinstalei o .Net 7 e instalei o .Net6. Continuava recebendo o erro: "error NU1100: Unable to resolve 'Swashbuckle.AspNetCore (>= 5.6.3)' for 'net5.0'". Então consegui instalar manualmente com o comando: dotnet nuget add source --name nuget.org https://api.nuget.org/v3/index.json

Ref.: https://stackoverflow.com/questions/67401228/error-trying-to-create-a-webapi-in-visual-studio-code

Antes disso, tive que instalar o NuGet provider e o NuGet PowerShell Module, ref.: https://ironpdf.com/blog/net-help/install-nuget-powershell-tutorial/

Outra referência: https://devblogs.microsoft.com/powershell/when-powershellget-v1-fails-to-install-the-nuget-provider/

Então instalei o pacote Microsoft.AspNetCore.OpenApi ref.: https://www.nuget.org/packages/Microsoft.AspNetCore.OpenApi/