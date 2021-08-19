#!/bin/sh
# ref: https://help.github.com/articles/adding-an-existing-project-to-github-using-the-command-line/
#
# Usage example: /bin/sh ./gen.sh models

args=$1

rm -rf gen

java -jar swagger-codegen-cli.jar generate \
    -i https://raw.githubusercontent.com/blockfrost/openapi/master/swagger.yaml \
    -l csharp \
    -c ./config.json \
    -o ./gen \
    -t csharp 

rm -f ./gen/*.sln
dotnet new sln -n Blockfrost.Gen -o ./gen
dotnet sln ./gen/Blockfrost.Gen.sln add ./gen/src/Blockfrost.Api/Blockfrost.Api.csproj
dotnet sln ./gen/Blockfrost.Gen.sln add ./gen/src/Blockfrost.Api.Test/Blockfrost.Api.Test.csproj
dotnet clean --nologo -v q
