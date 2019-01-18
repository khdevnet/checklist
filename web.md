### HTTP/2 Feature Upgrades
* **Multiplexed streams** Bi-directional sequence of text format frames sent over the HTTP/2 protocol exchanged between the server and client are known as “streams”
* **HTTP/2 Server Push** This capability allows the server to send additional cacheable information to the client that isn’t requested but is anticipated in future requests.
* **Stream prioritization** HTTP/2 implementation allows the client to provide preference to particular data streams. Although the server is not bound to follow these instructions from the client, the mechanism allows the server to optimize network resource allocation based on end-user requirements.
* **Stateful Header Compression** Сompress large number of redundant header frames. It uses the HPACK specification as a simple and secure approach to header compression.
