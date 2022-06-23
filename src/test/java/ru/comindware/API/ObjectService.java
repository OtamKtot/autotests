package ru.comindware.API;

import io.qameta.allure.Step;
import ru.comindware.API.models.ObjectServiceModel;

import java.util.Map;

import static io.restassured.RestAssured.given;
import static ru.comindware.API.Specs.Specs.request;
import static ru.comindware.API.Specs.Specs.responseSpec;

public class ObjectService {
    public void EditObjectById(String username, String password, String objectId, Map<String, String> objectData) {
        ObjectServiceModel objectServiceModel = new ObjectServiceModel(objectId,objectData);
        given()
                .spec(request)
                .auth().preemptive().basic(username, password)
                .body(objectServiceModel)
                .when()
                .post("/api/public/system/TeamNetwork/ObjectService/Edit")
                .then()
                .log().all()
                .spec(responseSpec).extract().response();
    }
    @Step("Удалить тестовые данные")
    public void DeleteObjectById(String username, String password, String objectId) {
        given()
                .spec(request)
                .auth().preemptive().basic(username, password)
                .body(objectId)
                .when()
                .post("/api/public/system/TeamNetwork/ObjectService/Delete")
                .then()
                .log().all()
                .spec(responseSpec).extract().response();
    }
}
