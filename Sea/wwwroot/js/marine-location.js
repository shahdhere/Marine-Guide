function loadMarineLocation(callback) {


    navigator.geolocation.getCurrentPosition(

        function (position) {


            let lat = position.coords.latitude;
            let lon = position.coords.longitude;


            let saved = sessionStorage.getItem("marineLocation");


            if (saved) {

                let location = JSON.parse(saved);

                callback(
                    location.lat,
                    location.lon,
                    location.name,
                    true
                );

            }
            else {


                // الحصول على اسم المدينة من الإحداثيات
                fetch(`https://nominatim.openstreetmap.org/reverse?lat=${lat}&lon=${lon}&format=json`)
                    .then(response => response.json())
                    .then(data => {


                        let address = data.address;


                        let city =
                            address.city ||
                            address.town ||
                            address.village ||
                            address.state ||
                            "Unknown Location";


                        callback(
                            lat,
                            lon,
                            city,
                            false
                        );


                    })
                    .catch(() => {


                        callback(
                            lat,
                            lon,
                            "Unknown Location",
                            false
                        );


                    });

            }


        },


        function () {


            callback(
                null,
                null,
                "Location unavailable",
                false
            );


        }

    );

}