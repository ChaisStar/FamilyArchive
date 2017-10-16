import sys
import os
import json
import codecs

DB_SERVER = sys.argv[1]
DB_PORT = sys.argv[2]
DB_NAME = sys.argv[3]
DB_USER = sys.argv[4]
DB_PASSWORD = sys.argv[5]

print('Argument List:', DB_NAME)
print('Argument List:', DB_SERVER)
script_dir = os.path.dirname(__file__)
rel_path = "FamilyArchive.Application/appsettings.json"
abs_file_path = os.path.join(script_dir, rel_path)
data = json.load(codecs.open(abs_file_path, "r", "utf-8-sig"))

data["AppSettings"]["Database"]["Server"] = DB_SERVER
data["AppSettings"]["Database"]["Port"] = DB_PORT
data["AppSettings"]["Database"]["Name"] = DB_NAME
data["AppSettings"]["Database"]["User"] = DB_USER
data["AppSettings"]["Database"]["Password"] = DB_PASSWORD

with open(abs_file_path, "w") as appConfig:
    json.dump(data, appConfig)