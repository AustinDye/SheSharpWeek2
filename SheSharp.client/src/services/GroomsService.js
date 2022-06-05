import { AppState } from "../AppState"
import { Groom } from "../models/Groom"
import { logger } from "../utils/Logger"
import { api } from "./AxiosService"



class GroomsService {

 async create(newGroom) {
  const res = await api.put("/api/groom", newGroom)
  AppState.grooms.unshift(new Groom(res.data))
  return new Groom(res.data)
 }
 async getAll() {
  const res = await api.get("/api/groom")
  AppState.grooms = res.data
  logger.log(AppState.grooms)
 }

 async getById(groom) {
  const res = await api.get("/api/groom/" + groom.id)
  AppState.focusGroom = res.data
  logger.log(AppState.focusGroom)
 }

 async delete(groom) {
  const res = await api.delete("/api/groom/" + groom.id)
 }
}

export const groomsService = new GroomsService() 