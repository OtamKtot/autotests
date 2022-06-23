package ru.comindware.API.models;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import lombok.Data;

import java.util.Map;

@Data
@JsonIgnoreProperties(ignoreUnknown = true)
public class ObjectServiceModel {
    private String objectId;
    private Map<String, String> objectData;

    public ObjectServiceModel(String taskId, Map<String, String> objectData) {
        this.objectId = taskId;
        this.objectData = objectData;
    }
    public ObjectServiceModel(String taskId) {
        this.objectId = taskId;
    }
}
