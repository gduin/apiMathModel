try:
	import json
	import argparse
	from urllib.parse import unquote
	import pandas as pd
except ImportError as e:
	print("Exception Import ")
	print("Args", e.args)
	print("Name", e.name)
	print("Path", e.path)
	exit(-1)

# Set up CLI Arguments
parser = argparse.ArgumentParser()

# Required Arguments
parser = argparse.ArgumentParser(description='Solve model'+ '{:^10}'.format('Hola'))

parser.add_argument("-D", "--Data", required=True,
                    help="JSON Data string for this model")

# Grab the Arguments
args = parser.parse_args()

jsonString = unquote(args.Data)

#print(jsonString)

data = json.loads(jsonString)

#print(data)


##data = json.load(jsonString)
##print(data)

df= pd.read_json(jsonString)

#print(df)


#df.to_json()
print(df.to_json(), end="")