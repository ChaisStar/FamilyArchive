jq ".ConnectionStrings.PostgreSQL = \"$1\"" ./\FamilyArchive.Application/\appsettings.json|sponge ./\FamilyArchive.Application/\appsettings.json