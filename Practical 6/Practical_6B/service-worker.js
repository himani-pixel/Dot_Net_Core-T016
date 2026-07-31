self.addEventListener("install", e => {
    console.log("Service work installed");
})

self.addEventListener("fetch", e => {
    r.responseWith(fetch(e.request));
})
