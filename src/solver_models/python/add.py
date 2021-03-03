#!/usr/bin/python3

#import sys

try:
	import json
	import argparse
except ImportError as e:
	print("Exception Import ")
	print("Args", e.args)
	print("Name", e.name)
	print("Path", e.path)
	exit(-1)



#print( 'Number of arguments:', len(sys.argv), 'arguments.')
#sys.argv.pop(0)
#print( 'Argument List:', str(sys.argv[1]))
#print( 'Argument List:', str(sys.argv[2]))
#print( 'Argument List:', str(sys.argv))


#for item in sys.argv:
#	acum=+item


parser = argparse.ArgumentParser(description='Solve model'+ '{:^10}'.format('Hola'))

parser.add_argument("-D", "--Data", required=True,
                    help="JSON Data string for this model")

#parser.add_argument('integers', metavar='N', type=list, nargs='+',
#                   help='an integer for the accumulator')

# Grab the Arguments
args = parser.parse_args()

jsonString = unquote(args.Data)

print(jsonString)

data = json.loads(jsonString)

result = map( sum, data) 
print(list(result), end="") 

#parser.add_argument('integers', store='ints', metavar='N', nargs='+',
#                   help='an integer for the accumulator')

#parser.add_argument('--sum', dest='accumulate', action='store_const',
#                   const=sum, default=max,
#                   help='sum the integers (default: find the max)')

#args = parser.parse_args()
#print(args.accumulate(args.integers))
