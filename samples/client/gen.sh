#!/bin/sh
# ref: https://help.github.com/articles/adding-an-existing-project-to-github-using-the-command-line/
#
# Usage example: /bin/sh ./gen.sh 

java -jar swagger-codegen-cli.jar generate -i https://raw.githubusercontent.com/blockfrost/openapi/master/swagger.yaml -l csharp -c config.json -t csharp/
