const CACHE_NAME = "college-pwa-cache-v1";

const FILES_TO_CACHE = [
    "/",
    "/offline.html",
    "/manifest.json"
];

self.addEventListener("install", event => {

    event.waitUntil(

        caches.open(CACHE_NAME).then(cache => {

            return cache.addAll(FILES_TO_CACHE);

        })

    );

    console.log("Service Worker Installed");

});

self.addEventListener("activate", event => {

    console.log("Service Worker Activated");

});

self.addEventListener("fetch", event => {

    event.respondWith(

        fetch(event.request)

            .catch(() => {

                return caches.match("/offline.html");

            })

    );

});
