import sys
import os
import json
import codecs
import requests

APPSETTINGS_URL = sys.argv[1]
APPSETTINGS_TOKEN = sys.argv[2]

response = requests.get(APPSETTINGS_URL, headers ={'secret-key':APPSETTINGS_TOKEN})

script_dir = os.path.dirname(__file__)
rel_path = "FamilyArchive.Application/appsettings.json"
abs_file_path = os.path.join(script_dir, rel_path)

with open(abs_file_path, "w") as appConfig:
    json.dump(response.json(), appConfig)