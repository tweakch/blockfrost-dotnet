#!/bin/sh
# ref: https://help.github.com/articles/adding-an-existing-project-to-github-using-the-command-line/
#
# Usage example: /bin/sh ./gen.sh models

args=$1

rm -rf gen/src/Blockfrost.Api.Gen/*

java -jar swagger-codegen-cli.jar generate \
    -i https://raw.githubusercontent.com/blockfrost/openapi/master/swagger.yaml \
    -l csharp \
    -o gen \
    -t templates \
    --additional-properties packageName=Blockfrost.Api.Gen \
                            apiPackage=Services \
                            packageGuid=0033076C-68A7-4EEB-9C66-74A266DCB6E0 \
                            targetFramework=v5.0 \

grep -rli 'AssetOnchainMetadata' gen/* | xargs -i@ sed -i 's/AssetOnchainMetadata/AssetMetadata/g' @

rm -f ./gen/*.sln
dotnet new sln -n Blockfrost.Gen -o ./gen
dotnet sln ./gen/Blockfrost.Gen.sln add ./gen/src/Blockfrost.Api.Gen/Blockfrost.Api.Gen.csproj
dotnet sln ./gen/Blockfrost.Gen.sln add ./gen/src/Blockfrost.Api.Gen.Test/Blockfrost.Api.Gen.Test.csproj
dotnet clean --nologo
dotnet build ./gen/Blockfrost.Gen.sln