import subprocess
import sys
import os

usage_string = 'python3 run.py filename.cs'

def main():
	if len(sys.argv) < 2:
		print(usage_string)
		return

	input_file = sys.argv[1]
	if not input_file.endswith('.cs'):
		print(usage_string)		
		return

	if not os.path.exists(input_file):
		print('file does not exist')
		return

	if not os.path.isfile(input_file):
		print(usage_string)
		return
	
	output_file = '.'.join(input_file.split('.')[:-1]) + '.exe'
	
	process = subprocess.Popen(['mcs', input_file])
	process.communicate()
	
	if process.returncode == 0:
		os.system(f'mono {output_file}')
		os.system(f'rm {output_file}')



if __name__ == "__main__":
	main()

