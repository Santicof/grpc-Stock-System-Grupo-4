from __future__ import print_function

import logging

import grpc
import greet_pb2
import greet_pb2_grpc


def run():
    with grpc.insecure_channel("localhost:5149") as channel:
        stub = greet_pb2_grpc.GreeterStub(channel)
        response = stub.SayHello(greet_pb2.HelloRequest(name = "world"))

        print ("\nMensaje recibido: " + response.message)

if __name__ == '__main__':
    logging.basicConfig()
    run()
