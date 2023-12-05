#!/bin/bash

######################
#Author -- David

#Date -- 29 Nov 2023
#####################

set -x #run script in  debug mode

set -e #Exits script when there is an error

set -o #Used to exit script when there is a pipefail error

df -h  #fnd the details about the disk space

free #Find details of memory

echo "Whats good"

nproc #Find CPU details



