//// Initialize and add the map
//let map;

//async function initMap() {
//    // The location of "Adventum" - zaimov
//    const position = { lat: 42.655, lng: 24.74594 };
//    // Request needed libraries.
//    //@ts-ignore
//    const { Map } = await google.maps.importLibrary("maps");
//    const { AdvancedMarkerView } = await google.maps.importLibrary("marker");

//    // The map, centered at "Adventum" - zaimov
//    map = new Map(document.getElementById("map"), {
//        zoom: 4,
//        center: position,
//        mapId: "DEMO_MAP_ID",
//    });

//    // The marker, positioned at "Adventum" - zaimov
//    const marker = new AdvancedMarkerView({
//        map: map,
//        position: position,
//        title: "Adventum",
//    });
//}

//initMap();

const buttons = document.querySelectorAll('button');

buttons.forEach(button => {
    button.addEventListener('click', () => {
        const faq = button.nextElementSibling;
        const icon = button.children[1];

        faq.classList.toggle('show');
        icon.classList.toggle('rotate');
    })
})
