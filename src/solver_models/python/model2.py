try:
	import json
	import argparse
	from urllib.parse import unquote
	import numpy as np
except ImportError as e:
	print("Exception Import ")
	print("Args", e.args)
	print("Name", e.name)
	print("Path", e.path)
	exit(-1)


def json2arr(astr, dtype):
	#print(json.loads(astr))
    return np.fromiter(json.loads(astr), dtype)



# Set up CLI Arguments
parser = argparse.ArgumentParser()

# Required Arguments
parser = argparse.ArgumentParser(description='Solve model'+ '{:^10}'.format('Hola'))

parser.add_argument("-D", "--Data", required=True,
                    help="JSON Data string for this model")

# Grab the Arguments
args = parser.parse_args()

jsonString = unquote(args.Data)

#print("Crudo ", jsonString)

#print("json.load ", json.loads(args.Data)["data"])
#print("type(json.load) ", type(json.loads(args.Data)["data"]))

arr=json.loads(args.Data)["data"]
#dt=np.int32
#arr=json2arr(args.Data, dt)


#print(repr(arr))

#result=[3*i for i in arr]
result=[i**3 for i in arr]
#print(json.dumps(result, indent=4))
print(result, end="")
#exit(result)
